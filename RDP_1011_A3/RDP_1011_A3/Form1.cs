using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP_1011_A3
{
    public partial class Form1 : Form
    {
        public int startRectangleTop = 30;
        public int startRectangleLeft = 50;
        public int RectangleWidth = 560;
        public int RectangleHeight = 300;
        public int LineTop = 20;
        public int LineLeft = 70;
        public int LineLength = 220;

        public int basketPositionLeft = 70;
        public int basketPositionTop = 240;
        public int basketWidth = 50;
        public int basketHeight = 30;

        public int basketPosition = 3;

        public Form1()
        {
            InitializeComponent();
            this.Height = Height + startRectangleTop + 100;
            this.Width = RectangleWidth + startRectangleLeft * 2 + 20;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen BluePen = new Pen(Color.Blue, 1);
            g.DrawRectangle(BluePen, new Rectangle(new Point(startRectangleLeft, startRectangleTop), new Size(RectangleWidth, RectangleHeight)));

            Pen RedPen = new Pen(Color.Red, 1);
            RedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            for (int i = 1; i < 8; i++)
            {
                g.DrawLine(RedPen, new Point(LineLeft * i + startRectangleLeft, LineTop + startRectangleTop), new Point(LineLeft * i + startRectangleLeft, LineTop + LineLength + startRectangleTop));
            }

            Pen PinkPen = new Pen(Color.Pink, 1);
            g.DrawRectangle(PinkPen, new Rectangle(new Point(basketPositionLeft * basketPosition + startRectangleLeft - (basketWidth / 2), basketPositionTop + startRectangleTop), new Size(basketWidth, basketHeight)));

            
            this.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
