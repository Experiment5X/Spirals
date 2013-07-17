using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DrawSpiral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // this could use some optimization, but ehhhhhhh not now
        private List<Point> GenerateSpiral(Point center, int pointCount, int tightness = 5, bool flipped = false, int seedRadius = 1)
        {
            if (tightness <= 0)
                throw new Exception("Tightness argument must be greater than 0.");

            List<Point> spiralPoints = new List<Point>();

            int radius = seedRadius;
            bool positive = !flipped;
            for (int x = (flipped) ? -radius : radius; spiralPoints.Count < pointCount; x = (positive) ? x - 1 : x + 1)
            {
                Point p = new Point() { X = x };

                // this is based off of the standard equation for a circle: x^2 + y^2 = r^2
                p.Y = (int)Math.Sqrt(radius * radius - x * x);

                if (!positive)
                    p.Y *= -1;

                // we need to flip the sign
                if (Math.Abs(x) == radius && spiralPoints.Count != 0)
                    positive = !positive;

                radius = seedRadius + (spiralPoints.Count / tightness);

                p.X += center.X;
                p.Y = center.Y - p.Y;
                spiralPoints.Add(p);
            }

            return spiralPoints;
        }

        private void btnSpiralColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                btnSpiralColor.BackColor = dialog.Color;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Graphics panelGrapics = panel1.CreateGraphics();
            panelGrapics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // generate the spiral around the location that the user clicked
            List<Point> spiralPoints = GenerateSpiral(panel1.PointToClient(Cursor.Position), 
                                                     (int)intSpiralLength.Value, 
                                                     (int)intTightness.Value, 
                                                     chxFlipped.Checked, 
                                                     (int)intSeedRadius.Value);

            // create a pen based off of the user's parameters
            Pen pen = new Pen(btnSpiralColor.BackColor);
            pen.Width = (float)intThickness.Value;

            // connect all of the points generated with the pen that the user chose
            for (int i = 0; i < spiralPoints.Count - 1; i++)
                panelGrapics.DrawLine(pen, spiralPoints[i], spiralPoints[i + 1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
        }
    }
}
