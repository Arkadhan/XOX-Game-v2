using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgresTest
{
    public partial class XoxTimeBar : Control
    {
        private int redValue=0;

        public XoxTimeBar()
        {
            this.SetStyle(
             ControlStyles.UserPaint |
             ControlStyles.AllPaintingInWmPaint |
             ControlStyles.DoubleBuffer, true);
        }

        public int RedValue
        {
            get { return redValue; }
            set
            {
                if (redValue != value)
                {
                    redValue = value;
                    if (redValue > 10)
                        redValue = 10;
                    else if (redValue < 0)
                        redValue = 0;

                    Invalidate();
                }

            }

        }
        public int BlueValue
        {
            get { return 10 - redValue; }
            set { RedValue = 10 - value; }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           
            int cirWidth = Height - 4;
            int width = Width - cirWidth-2;
            int middle = (int)(width * RedValue / 10.0f);
            int start = cirWidth / 2;
            

            double barWidth = (width) / 10;
            double splitWidth = 3;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.InterpolationMode = InterpolationMode.High;

            e.Graphics.FillRectangle(new SolidBrush(BackColor),new Rectangle(0,0,Width,Height));

            Rectangle redRect=new Rectangle(start,4,middle,Height-8);

            e.Graphics.FillRectangle(Brushes.Blue,new Rectangle(start, 4,width,Height-8));

            e.Graphics.FillRectangle(Brushes.Red,redRect);



            for (int i = 1; i < 10; i++)
            {
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(start + (int)((width * i / 10.0f)-splitWidth/2), 4, (int)splitWidth, Height - 8));
            }

        

            e.Graphics.DrawRectangle(new Pen(Color.Silver, 1), new Rectangle(start, 4,width,Height-8));

            e.Graphics.FillEllipse(Brushes.White,new Rectangle(start+middle-cirWidth/2,(Height-cirWidth)/2,cirWidth, cirWidth));

            e.Graphics.DrawEllipse(new Pen(Color.DarkSlateGray,2), new Rectangle(start + middle - cirWidth / 2+1 , (Height - cirWidth) / 2+1, cirWidth-2, cirWidth-2));

            e.Graphics.DrawEllipse(Pens.DarkGray, new Rectangle(start+middle - cirWidth / 2 + 4, (Height - cirWidth) / 2 + 4, cirWidth - 8, cirWidth - 8));



        }
    }
}
