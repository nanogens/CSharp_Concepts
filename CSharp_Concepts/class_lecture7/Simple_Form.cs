using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace CSharp_Concepts
{
    public partial class Simple_Form : Form
    {
        public Simple_Form()
        {
            InitializeComponent();
        }

        private void Simple_Form_Paint(object sender, PaintEventArgs e)
        {
            
            // Hello World
            Graphics g = e.Graphics;
            Font myfont = new Font("Times New Roman", 60);
            SolidBrush mybrush = new SolidBrush(Color.Green);
            g.DrawString("Hello World!", myfont, mybrush, 250, 250);
            
            // Line.  5 is thickness of the line
            Pen mypen = new Pen(Color.Red, 5);
            g.DrawLine(mypen, 20, 30, 200, 60);

            // Rectangle
            mybrush.Color = Color.Blue;
            g.FillRectangle(mybrush, 20, 70, 150, 100);
            g.DrawRectangle(mypen, 20, 70, 150, 100);

            // Ellipse
            g.FillEllipse(mybrush, 20, 200, 150, 100);
            g.DrawEllipse(mypen, 20, 200, 150, 100);

            mybrush.Color = Color.FromArgb(20, 0, 255, 0);

            // Pie
            g.FillPie(mybrush, 210, 40, 100, 100, 0, 140);
            g.DrawPie(mypen, 210, 40, 100, 100, 0, 140);

            mybrush.Color = Color.Yellow;

            // Polygon
            Point[] p = new Point[]
                        {
                            new Point (250, 170),
                            new Point (310, 245),
                            new Point (340, 170),
                            new Point (300, 140),
                            new Point (290, 170),
                        };
            g.FillPolygon(mybrush, p);
            g.DrawPolygon(mypen, p);

            // Draw a curve through an array of points
            Point[] pcurve = new Point[]
                             {
                                new Point (0, 570),
                                new Point (50, 545),
                                new Point (100, 500),
                                new Point (150, 597),
                                new Point (200, 522),
                             };
            g.DrawCurve(mypen, pcurve);

            // Icon - get the file path from (note the backslash is this way / rather than \ way)
            this.Icon = Icon.ExtractAssociatedIcon("C:/Learn/Learning/CSharp_Concepts/CSharp_Concepts/class_lecture7/Images and Icons/penguin-1-1.ico");
            g.DrawIcon(Icon, 400, 400);

            // Picture 
            Image img = Image.FromFile("C:/Learn/Learning/CSharp_Concepts/CSharp_Concepts/class_lecture7/Images and Icons/waterfall.jpg");
            g.DrawImage(img, 700, 400);

            // Rectangle - Dashstyle
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(mypen, 20 + 500, 150, 150 + 500, 100);

            // Background Color
            BackColor = Color.LightSalmon;

            // Rectangle - Gradient Fill
            // Here the two Point objects specify the starting and ending point of the gradient fill while the Color objects 
            // represent the starting and ending colors of the gradient fill.
            // The important point to note here is that the y coordinates of both the points must be same for the gradient
            // fill to be filled horizontally
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(440, 20), new Point(540, 20), Color.Yellow, Color.Brown);
            g.DrawRectangle(mypen, 440, 20, 100, 200);
            g.FillRectangle(lgb, 440, 20, 100, 200);
            
            /*
            // Telephone Window
            // Note : Comment out all of the above when running this.
            // When this run, expand the window in both the x and y direction by dragging it.
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(475, 175, 565, 300);
            gp.AddLine(565, 340, 70, 340);
            gp.AddLine(70, 300, 140, 175);
            gp.AddLine(210, 175, 210, 170);
            gp.AddLine(135, 170, 122, 195);
            gp.AddLine(70, 195, 55, 155);
            gp.AddLine(55, 120, 580, 120);
            gp.AddLine(580, 155, 565, 195);
            gp.AddLine(513, 195, 500, 170);
            gp.AddLine(425, 170, 425, 175);
            Region = new Region(gp);
            */
        }
    }
}
