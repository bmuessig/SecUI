using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecUI
{
    public partial class SecScreen : UserControl
    {
        private Image img;

        public SecScreen()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get
            {
                return img;
            }

            set
            {
                Image oldImage = img;
                img = value;
                this.pbScreen.Image = img;
                if(oldImage != null)
                    oldImage.Dispose();
            }
        }
    }
}
