using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steny
{
    public partial class Form1 : Form
    {
        List<Point> points = new List<Point>();
        List<Point> point2 = new List<Point>();
        public Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
        
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int w = ClientRectangle.Width;
            int h = ClientRectangle.Height;
            points.Add(new Point(w / 2 - w / 8, h / 2 - h / 8));            
            skyBluePen.Width = 8;
            //skyBluePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            const int radius = 5;
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillPolygon(brush: Brushes.Blue, points.ToArray());
            if (points.Count>2)
            {
                //e.Graphics.DrawPolygon(pen: skyBluePen, points.ToArray());                
                for (int i=0;i<points.Count-1;i++)
                {
                    point2.Add(points[i]);
                    point2.Add(points[i+1]);
                    point2.Add(new Point(points[i+1].X, points[i+1].Y - (int)HeightText.Value ));
                    point2.Add(new Point(points[i].X, points[i].Y - (int)HeightText.Value ));
                    e.Graphics.FillPolygon(brush: Brushes.Aqua, point2.ToArray());
                    for (int i2 = 0; i2 < 4; i2++) { point2.RemoveAt(0); }
                }
                point2.Add(points[points.Count-1]);
                point2.Add(points[0]);
                point2.Add(new Point(points[0].X, points[0].Y - (int)HeightText.Value));
                point2.Add(new Point(points[points.Count-1].X, points[points.Count-1].Y - (int)HeightText.Value));
                e.Graphics.FillPolygon(brush: Brushes.Aqua, point2.ToArray());
                for (int i = 0; i < 4; i++) { point2.RemoveAt(0); }
            }
            foreach (Point p in points)
            {
                e.Graphics.FillEllipse(brush: Brushes.Red,
                x: p.X - radius,
                y: p.Y - radius - Convert.ToInt32(HeightText.Value),
                width: 2 * radius,
                height: 2 * radius);
            }
        }
        private void addpoint(Point p)
        {
            points.Add(p);
            Invalidate();
            Area.Text = $"Sv={Math.Round(Calculator.Perimeter(Convert.ToInt32(HeightText.Value),points)*1000000)}mm^2";
            AreaRoom.Text = $"Sr={Calculator.Area(points) * 1000000}mm^2";

        }
        private void add_Click(object sender, EventArgs e)
        {
            Point last = points[points.Count - 1];
            Point curr = new Point(
                x: last.X + Convert.ToInt32(Convert.ToDouble(longtext.Value) * Math.Sin(Convert.ToDouble(angle_textbox.Value) / 180.0 * Math.PI)),
                y: last.Y + Convert.ToInt32(Convert.ToDouble(longtext.Value) * Math.Cos(Convert.ToDouble(angle_textbox.Value) / 180.0 * Math.PI))
                );
            addpoint(curr);
           
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (points.Count > 1)
            {
                points.RemoveAt(points.Count - 1);
                Invalidate();
            }            
        }

        private void label_angle_Click(object sender, EventArgs e)
        {

        }

        private void long_lable_Click(object sender, EventArgs e)
        {

        }    

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            addpoint(new Point(e.X, e.Y));
        }
    }
}
