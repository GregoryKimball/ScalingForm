using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace ScalingFormNamespace
{
    public class ScalingForm : Form
    {

        protected int lastWidth, lastHeight;
        protected bool justMaximized;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lastHeight = this.Size.Height;
            lastWidth = this.Size.Width;
            justMaximized = false;
        }


       


        protected void ScaleForm()
        {

            float scaleX = (float)this.Width / (float)lastWidth;
            float scaleY = (float)this.Height / (float)lastHeight;


            if (justMaximized && this.WindowState == FormWindowState.Normal)
            {
                justMaximized = false;
                scaleX = 0.5f;
                scaleY = 0.5f;
            }

            this.Height = lastHeight;
            this.Width = lastWidth;

            this.Scale(new SizeF(scaleX, scaleY));

            lastHeight = this.Height;
            lastWidth = this.Width;

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Maximized)
            {
                ScaleForm();
                justMaximized = true;
                return;
            }
            if (justMaximized && this.WindowState == FormWindowState.Normal)
            {
                ScaleForm();
            }
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            ScaleForm();
        }
       

    }
}
