using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Net;
using System.Collections.Specialized;

namespace SecAPI.Keypad
{
    public class KeyEngine
    {
        public Uri BaseUri
        {
            get;
            private set;
        }

        private Uri RequestUri
        {
            get
            {
                return new Uri(BaseUri, "/sec_virtkeypad_events.cgx");
            }
        }

        public NetworkCredential Credentials
        {
            get;
            private set;
        }

        public string SessionID
        {
            get
            {
                return Ssid;
            }

            set
            {
                bool wasRunning = Timer.Enabled;
                Timer.Stop();

                try
                {
                    this.Web.Headers.Remove(HttpRequestHeader.Cookie);
                }
                catch (Exception)
                { }

                this.Web.Headers.Add(HttpRequestHeader.Cookie, "ssid=" + value);
                Ssid = value;

                Timer.Enabled = wasRunning;
            }
        }

        public bool IsRunning
        {
            get
            {
                return Timer.Enabled;
            }
        }

        public uint UpdateInterval
        {
            get
            {
                return (uint)Timer.Interval;
            }
        }

        public uint QueuedKeys
        {
            get
            {
                bool wasRunning = Timer.Enabled;
                Timer.Stop();
                uint num = (uint)KeyQueue.Count;
                Timer.Enabled = wasRunning;
                return num;
            }
        }

        public event EventHandler<UnhandledExceptionEventArgs> ErrorThrown;

        private Queue<char> KeyQueue;

        private Timer Timer;

        private WebClient Web;

        private string Ssid;

        public KeyEngine(Uri BaseUri, NetworkCredential Credentials, uint UpdateInterval = 50)
        {
            this.BaseUri = BaseUri;
            this.Credentials = Credentials;
            this.Ssid = "";

            this.KeyQueue = new Queue<char>();
            this.Timer = new Timer(UpdateInterval);
            this.Web = new WebClient();

            this.Timer.AutoReset = false;
            this.Timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);

            this.Web.Encoding = Encoding.UTF8;
            this.Web.Credentials = Credentials;
            this.Web.UploadValuesCompleted += new UploadValuesCompletedEventHandler(Web_UploadValuesCompleted);

            ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;
        }

        void Web_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                OnErrorThrown(new UnhandledExceptionEventArgs(e.Error, false));
                return;
            }

            Timer.Start();
        }

        public void Run()
        {
            Timer.Start();
        }

        public void Stop()
        {
            Timer.Stop();
        }

        public void EnqueueKey(char KeyToken)
        {
            bool wasRunning = Timer.Enabled;
            Timer.Stop();
            KeyQueue.Enqueue(KeyToken);
            Timer.Enabled = wasRunning;
        }

        public void ClearQueue()
        {
            bool wasRunning = Timer.Enabled;
            Timer.Stop();
            KeyQueue.Clear();
            Timer.Enabled = wasRunning;
        }

        protected virtual void OnErrorThrown(UnhandledExceptionEventArgs e)
        {
            EventHandler<UnhandledExceptionEventArgs> handler = ErrorThrown;
            if (handler != null)
                handler(this, e);
        }

        private void PostKey(char KeyToken)
        {
            NameValueCollection post = new NameValueCollection();
            post.Add("vkp_key_events", KeyToken.ToString());
            post.Add("ssid", SessionID);
            Web.UploadValuesAsync(RequestUri, null, post);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!Web.IsBusy)
            {
                if (KeyQueue.Count > 0)
                    PostKey(KeyQueue.Dequeue());
                else
                    Timer.Start();
            }
            else
                Timer.Start();
        }

    }
}
