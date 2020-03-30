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
        Graphics DrawingZone;
        Graphics SizeSample;
        Graphics ColorSample;
        Brush Brush;
        private int BrushSize = 1;
        private int BrushForm = 1;
        Pen Pen;
        Point LastPoint;

        List<Point> points = new List<Point>();

        public int Brushsize {get{return BrushSize;}set{BrushSize = value;}}

        public Form1()
        {
            InitializeComponent();

            //create graphic for the controller
            DrawingZone = drawingPanel.CreateGraphics();
            SizeSample = sizeSamplePanel.CreateGraphics();
            ColorSample = SelectedColorPanel.CreateGraphics();

            //graphics events
            drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);

            //anti-aliasing (lissage)
            var antiAlising = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            DrawingZone.SmoothingMode = antiAlising;
            SizeSample.SmoothingMode = antiAlising;
            ColorSample.SmoothingMode = antiAlising;

            //quality of the composition
            var compositionQuality = System.Drawing.Drawing2D.CompositingQuality.Invalid;
            DrawingZone.CompositingQuality = compositionQuality;
            SizeSample.CompositingQuality = compositionQuality;
            ColorSample.CompositingQuality = compositionQuality;


            //Tools
            Brush = new SolidBrush(Color.Black);
            Pen = new Pen(Brush, Brushsize);

            //line shape
            Pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            //line joints
            Pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

            //line joint width
            Pen.MiterLimit = Pen.Width * 1.25f;

            // Create a custom dash pattern.
            // Pen.DashPattern = new float[] { 40.0F, 20.0F, 10.0F, 30.0F };

            // Draw a line.
            // DrawingZone.DrawLine(Pen, 20.0F, 20.0F, 100.0F, 240.0F);

            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            this.BrushSizeTrackBar.DataBindings.Add(
                                "Value",
                                this,
                                "Brushsize",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            showCoordinates(e);
            if (clicked)
            {
                points.Add(e.Location);
                //g.FillEllipse(b, e.X, e.Y, brushsize, brushsize);
                //g.DrawEllipse();
                //g.DrawLine(p, last,e.Location); 

                if(Brushsize<=1)
                    DrawingZone.DrawLine(Pen, LastPoint, e.Location);
                else
                    DrawingZone.DrawLines(Pen, points.ToArray());

                lastX = e.X;
                lastY = e.Y;
                LastPoint = e.Location;
                //this.Invalidate();
            }
                
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            showCoordinates(e);
            //DrawingZone.FillRectangle(Brush, e.X, e.Y, BrushSize, BrushSize);
            points.Add(e.Location);
            lastX = e.X;
            lastY = e.Y;
            LastPoint = e.Location;
            clicked = true;
            DrawingZone.DrawLine(Pen, LastPoint, e.Location);
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

        /// <summary>
        /// Does something arbitrary (TO REMOVE)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DrawingZone.Clear(Color.White);
            DrawingZone.DrawLines(Pen, new Point[] { new Point(0, 50), new Point(500, 50) });
            DrawingZone.DrawLines(Pen, new Point[] { new Point(0, 100), new Point(400, 100) });
            
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BrushSizeLabel_display.Text = BrushSize + " px";

            Brush = new SolidBrush(Color.Black);
            Pen = new Pen(Brush, Brushsize);

            //Update Visualisation Sample
            SizeSample.DrawLines(Pen, new Point[] { 
                    //from
                new Point(sizeSamplePanel.Location.X, sizeSamplePanel.Location.Y), 
                    // to
                new Point(sizeSamplePanel.Location.X + sizeSamplePanel.Size.Width, sizeSamplePanel.Location.Y + sizeSamplePanel.Size.Height) 
            }); 
        }

        private void showCoordinates(MouseEventArgs e)
        {
            PointerCoordsLabel_display.Text = "x : " + e.X + ";   y : " + e.Y;
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
