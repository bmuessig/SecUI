using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecAPI.Session
{
    public class ConnectionEventArgs : EventArgs
    {
        public bool Success
        {
            get;
            private set;
        }

        public string SessionID
        {
            get;
            private set;
        }

        public ConnectionEventArgs(bool Success, string SessionID = "") : base()
        {
            this.Success = Success;
            this.SessionID = SessionID;
        }
    }
}
