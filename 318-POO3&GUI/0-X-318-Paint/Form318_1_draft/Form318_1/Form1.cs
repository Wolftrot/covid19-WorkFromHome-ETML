using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form318_1
{
    public partial class Form1 : Form
    {
        bool clicked;
        int lastX, lastY;
        //int endX, endY;
        Graphics g;
        Brush b;
        int brushsize=1;
        Pen p;
        Point last;

        List<Point> points = new List<Point>();

        public int Brushsize
        {
            get
            {
                return brushsize;
            }

            set
            {
                brushsize = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Invalid;
            b = new SolidBrush(Color.Black);
            p = new Pen(b, Brushsize);
            //p.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            //p.DashPattern=;


            //p.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            // Create a custom dash pattern.
            //p.DashPattern = new float[] { 40.0F, 20.0F, 10.0F, 30.0F };

            //p.MiterLimit = p.Width * 1.25f;
            //p.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

            // Draw a line.
            //e.Graphics.DrawLine(greenPen, 20.0F, 20.0F, 100.0F, 240.0F);
            //p.EndCap

            this.trackBar1.DataBindings.Add("Value",
                                this,
                                "Brushsize",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            showCoordinates(e);
            if (clicked)
            {
                points.Add(e.Location);
                //g.FillEllipse(b, e.X, e.Y, brushsize, brushsize);
                //g.DrawEllipse()
                //g.DrawLine(p, last,e.Location); 

                if(Brushsize<=1)
                    g.DrawLine(p, last, e.Location);
                else
                    g.DrawLines(p, points.ToArray());





                lastX = e.X;
                lastY = e.Y;
                last = e.Location;
                //this.Invalidate();
            }
                
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            showCoordinates(e);
            //g.FillRectangle(b, e.X, e.Y, brushsize, brushsize);
            points.Add(e.Location);
            lastX = e.X;
            lastY = e.Y;
            last = e.Location;
            clicked = true;
            //g.DrawLine(p, 50, 50, 254, 254);
        }

 

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            showCoordinates(e);
            clicked = false;
            /*if (points.Count % 2 != 0)
            {
                points.Add(e.Location);
            }*/

            
            points.Clear();
            //this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawLines(p, new Point[] { new Point(0, 50), new Point(500, 50) });
            g.DrawLines(p, new Point[] { new Point(0, 100), new Point(400, 100) });
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "  scroll value:" + trackBar1.Value + "   brushsize" + brushsize;
            b = new SolidBrush(Color.Black);
            p = new Pen(b, Brushsize);
        }

        private void showCoordinates(MouseEventArgs e)
        {
            label1.Text = "x:" + e.X + "   y:" + e.Y;
        }
        /*
protected override void OnPaint(PaintEventArgs e)
{
   base.OnPaint(e);
   for(int i=0;i<points.Count-1;i++)
   {
       g.DrawLine(p, points[i],points[i+1]);
   }
}*/
    }
}
