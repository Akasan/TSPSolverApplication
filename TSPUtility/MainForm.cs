using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TSPUtility
{
    public partial class MainForm : Form
    {
        public Cities cities;
        int  circleRadius = 10;

        public MainForm()
        {
            InitializeComponent();
            InitializeMembers();
        }

        private void InitializeMembers()
        {
            cities = new Cities();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mapPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            cities.Add(new City(e.X, e.Y));
            drawCity(e.X, e.Y);

            drawAllArrow();

        }

        private void drawCity(int x, int y)
        {
            Bitmap canvas;
            if (mapPictureBox.Image == null)
            {
                canvas = new Bitmap(mapPictureBox.Width, mapPictureBox.Height);
            }
            else
            {
                canvas = new Bitmap(mapPictureBox.Image);
            }

            Graphics g = Graphics.FromImage(canvas);
            g.DrawEllipse(Pens.Black, x, y, circleRadius, circleRadius);
            g.Dispose();
            mapPictureBox.Image = canvas;
        }

        private void drawAllArrow()
        {
            for(int i=0; i<cities.Count()-1; i++)
            {
                drawArrow(cities[i], cities[i + 1]);
            }
        }

        private void drawArrow(City city1, City city2, int width=3)
        {
            Bitmap canvas = new Bitmap(mapPictureBox.Image);
            Graphics g = Graphics.FromImage(canvas);

            Pen blackPen = new Pen(Color.Black, width);
            blackPen.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(blackPen, city1.i, city1.j, city2.i, city2.j);

            g.Dispose();
            mapPictureBox.Image = canvas;
        }
    }
}
