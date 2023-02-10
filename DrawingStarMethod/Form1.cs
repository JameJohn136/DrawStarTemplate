using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        PointF[] points = new PointF[10];
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.

            ///float size = Convert.ToSingle(sizeInput.Text); 
            
            g = this.CreateGraphics(); //for part 4 this gets moved to the custom methods.
            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White, 3);

            points[0] = new PointF(110, 5);
            points[1] = new PointF(140, 80);
            points[2] = new PointF(225, 80);
            points[3] = new PointF(155, 125);
            points[4] = new PointF(180, 200);
            points[5] = new PointF(115, 160);
            points[6] = new PointF(40, 200);
            points[7] = new PointF(70, 130);
            points[8] = new PointF(5, 80);
            points[9] = new PointF(85, 80);

            g.DrawPolygon(whitePen, points);
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Brush blackBrush = new SolidBrush(Color.Black);

            points[0] = new PointF(110, 5);
            points[1] = new PointF(140, 80);
            points[2] = new PointF(225, 80);
            points[3] = new PointF(155, 125);
            points[4] = new PointF(180, 200);
            points[5] = new PointF(115, 160);
            points[6] = new PointF(40, 200);
            points[7] = new PointF(70, 130);
            points[8] = new PointF(5, 80);
            points[9] = new PointF(85, 80);

            g.FillPolygon(blackBrush, points);
        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
            

        }

    }
}
