using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Timers;
using System.IO;
using System.Drawing;

namespace SecAPI.Screen
{
    public class ScreenEngine
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
                return new Uri(BaseUri, "/sec_virtkeypad_raster.bmp");
            }
        }

        public NetworkCredential Credentials
        {
            get;
            private set;
        }

        public uint UpdateInterval
        {
            get
            {
                return (uint)Timer.Interval;
            }
        }

        public bool IsRunning
        {
            get
            {
                return Timer.Enabled;
            }
        }

        public event EventHandler<UnhandledExceptionEventArgs> ErrorThrown;

        public event EventHandler<RenderEventArgs> FrameRendered;

        private Timer Timer;

        private WebClient Web;

        public ScreenEngine(Uri BaseUri, NetworkCredential Credentials, uint UpdateInterval = 150)
        {
            this.BaseUri = BaseUri;
            this.Credentials = Credentials;

            this.Timer = new Timer(UpdateInterval);
            this.Web = new WebClient();

            this.Timer.AutoReset = false;
            this.Timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);

            this.Web.Credentials = Credentials;
            this.Web.DownloadDataCompleted += new DownloadDataCompletedEventHandler(Web_DownloadDataCompleted);

            ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;
        }

        private void Web_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                OnErrorThrown(new UnhandledExceptionEventArgs(e.Error, false));
                return;
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(e.Result) { Position = 0 })
                {
                    OnFrameRendered(new RenderEventArgs(new Bitmap(ms)));
                }
            }
            catch (Exception ex)
            {
                OnErrorThrown(new UnhandledExceptionEventArgs(ex, false));
                return;
            }

            Timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!Web.IsBusy)
            {
                Web.DownloadDataAsync(RequestUri);
            }
            else
                Timer.Start();
        }

        protected virtual void OnErrorThrown(UnhandledExceptionEventArgs e)
        {
            EventHandler<UnhandledExceptionEventArgs> handler = ErrorThrown;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void OnFrameRendered(RenderEventArgs e)
        {
            EventHandler<RenderEventArgs> handler = FrameRendered;
            if (handler != null)
                handler(this, e);
        }

        public void Run()
        {
            Timer.Start();
        }

        public void Stop()
        {
            Timer.Stop();
        }
    }
}
