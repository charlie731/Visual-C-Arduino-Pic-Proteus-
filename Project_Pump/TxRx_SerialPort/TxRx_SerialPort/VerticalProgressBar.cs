using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TxRx_SerialPort
{
    public class VerticalProgressBar : ProgressBar
    {

        public VerticalProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
         protected override void OnPaint(PaintEventArgs e)
         {
            // SolidBrush brush = null;

             Rectangle rec = new Rectangle(0,0, this.Width, this.Height);


             if (ProgressBarRenderer.IsSupported)
                 ProgressBarRenderer.DrawVerticalBar(e.Graphics, rec);


             if (Value != 0)
             {
                 Rectangle r1 = new Rectangle(rec.X, rec.Y, rec.Width, rec.Height);
                 int Altura = (int)(((double)Value * (double)this.Height) / 100);
                 r1.Y = r1.Bottom - Altura;
                 r1.Height = Altura;
                 LinearGradientBrush brush = new LinearGradientBrush(r1, this.BackColor, this.ForeColor, LinearGradientMode.Vertical);                  
                 //brush = new SolidBrush(this.ForeColor);
                 e.Graphics.FillRectangle(brush, r1.X + 2, r1.Y, r1.Width - 4, Altura);
             }

             
         }
        
     }
 }
         /*
        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 2; // A single inset value to control teh sizing of the inner rect.

            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                    if (rect.Width == 0) rect.Width = 1; // Can't draw rec with width of 0.

                    LinearGradientBrush brush = new LinearGradientBrush(rect, this.BackColor, this.ForeColor, LinearGradientMode.Vertical);
                    offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                    offscreenImage.Dispose();
                }
            }
        }
    }
}
        */