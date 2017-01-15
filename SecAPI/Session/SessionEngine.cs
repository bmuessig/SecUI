using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Specialized;

namespace SecAPI.Session
{
    public class SessionEngine
    {
        public Uri BaseUri
        {
            get;
            private set;
        }

        public NetworkCredential Credentials
        {
            get;
            private set;
        }

        public string SessionID
        {
            get;
            private set;
        }

        public bool IsLoggedIn
        {
            get;
            private set;
        }

        private Uri LoginRequestUri
        {
            get
            {
                return new Uri(BaseUri, "/sec_login.cgi");
            }
        }

        private Uri LogoutRequestUri
        {
            get
            {
                return new Uri(BaseUri, "/index.htm");
            }
        }

        public event EventHandler<ConnectionEventArgs> LogIn;

        public event EventHandler<EventArgs> LogOut;

        public event EventHandler<ConnectionEventArgs> ConnectionStatus;

        public event EventHandler<UnhandledExceptionEventArgs> ErrorThrown;

        private WebClient Web;

        private Regex SsidMatcher;

        public SessionEngine(Uri BaseUri, NetworkCredential Credentials)
        {
            this.BaseUri = BaseUri;
            this.Credentials = Credentials;
            this.SessionID = "";

            SsidMatcher = new Regex("<input type=\"hidden\" value=\"([0-9]*)\" id=\"ssid\" \\/>");

            this.Web = new WebClient();
            this.Web.Encoding = Encoding.UTF8;
            this.Web.Credentials = Credentials;
            this.Web.UploadValuesCompleted += new UploadValuesCompletedEventHandler(Web_UploadValuesCompleted);
            this.Web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Web_DownloadStringCompleted);

            ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;
        }

        void Web_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            if (!IsLoggedIn)
            {
                // We are now logging in
                // Extract the SSID first
                try
                {
                    SessionID = ExtractSSID(e.Result);
                }
                catch (Exception ex)
                {
                    OnErrorThrown(new UnhandledExceptionEventArgs(ex, false));
                    return;
                }

                if (SessionID != "")
                {
                    Web.Headers.Add(HttpRequestHeader.Cookie, "ssid=" + SessionID);
                    IsLoggedIn = true;
                    OnLogIn(new ConnectionEventArgs(true, SessionID));
                }
                else
                {
                    IsLoggedIn = false;
                    OnLogIn(new ConnectionEventArgs(false));
                }
            }
            else
            {

            }
        }

        private void Web_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {

            }
        }

        private string ExtractSSID(byte[] PostReply)
        {
            string cont = Encoding.UTF8.GetString(PostReply);
            Match match = SsidMatcher.Match(cont);
            if (match.Success)
            {
                if (match.Groups.Count == 2)
                    return match.Groups[1].Value;
            }

            return "";
        }

        public void DoLogIn()
        {
            // Make sure we are starting in the right mode as the request will be processed based on this setting
            IsLoggedIn = false;

            // Prepare login post
            NameValueCollection post = new NameValueCollection();
            post.Add("usr", Credentials.UserName);
            post.Add("pwd", Credentials.Password);

            // HTTP Post the login request
            Web.UploadValuesAsync(LoginRequestUri, null, post);
        }

        public void CheckConnection()
        {

        }

        public void DoLogOut()
        {
            // Make sure we are starting in the right mode as the request will be processed based on this setting
            IsLoggedIn = true;

        }

        protected virtual void OnLogIn(ConnectionEventArgs e)
        {
            EventHandler<ConnectionEventArgs> handler = LogIn;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void OnLogOut()
        {
            EventHandler<EventArgs> handler = LogOut;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        protected virtual void OnConnectionStatus(ConnectionEventArgs e)
        {
            EventHandler<ConnectionEventArgs> handler = ConnectionStatus;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void OnErrorThrown(UnhandledExceptionEventArgs e)
        {
            EventHandler<UnhandledExceptionEventArgs> handler = ErrorThrown;
            if (handler != null)
                handler(this, e);
        }
    }
}
