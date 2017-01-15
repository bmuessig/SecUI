using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SecAPI.Screen
{
    public class RenderEventArgs : EventArgs
    {
        public Bitmap Frame
        {
            get;
            private set;
        }

        public RenderEventArgs(Bitmap Frame) : base()
        {
            this.Frame = Frame;
        }
    }
}
