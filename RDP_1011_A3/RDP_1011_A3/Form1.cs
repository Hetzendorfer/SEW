using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

        public int TextTop = 600;
        public int TextLeft = 100;

        public int basketPositionLeft = 70;
        public int basketPositionTop = 240;
        public int basketWidth = 50;
        public int basketHeight = 30;

        public int basketPosition = 3;

        public int Punkte = 0;

        public bool GameOver = false;

        List<Apfel> Äpfel = new List<Apfel>();
        Thread äpfelAdd = null;

        public Form1()
        {
            InitializeComponent();
            this.Height = Height + startRectangleTop + 100;
            this.Width = RectangleWidth + startRectangleLeft * 2 + 20;

            //CreateRandomApfel();
            //Äpfel.Add(new Apfel(3, startRectangleTop + LineTop + 220, 54, startRectangleLeft + LineLeft * 3, startRectangleTop + LineTop));
            timer1.Start();

            äpfelAdd = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        System.Threading.Thread.Sleep(1000);
                        if (Äpfel.Count < 3)
                            this.CreateRandomApfel();
                    }
                    catch(ThreadAbortException ex)
                    {

                    }
                }
            });

            äpfelAdd.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            if (!GameOver)
            {
                Pen BluePen = new Pen(Color.Blue, 1);
                g.DrawRectangle(BluePen, new Rectangle(new Point(startRectangleLeft, startRectangleTop), new Size(RectangleWidth, RectangleHeight)));

                Pen RedPen = new Pen(Color.Red, 1);
                RedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                for (int i = 1; i < 8; i++)
                {
                    g.DrawLine(RedPen, new Point(LineLeft * i + startRectangleLeft, LineTop + startRectangleTop), new Point(LineLeft * i + startRectangleLeft, LineTop + LineLength + startRectangleTop));
                }

                foreach (Apfel item in Äpfel)
                {
                    g.DrawEllipse(Pens.Red, new Rectangle(item.X - 5, item.Y - 5, 10, 10));
                }

                Pen PinkPen = new Pen(Color.Pink, 1);
                g.DrawRectangle(PinkPen, new Rectangle(new Point(basketPositionLeft * basketPosition + startRectangleLeft - (basketWidth / 2), basketPositionTop + startRectangleTop), new Size(basketWidth, basketHeight)));


                Punktezahl.Text = Punkte.ToString();
            }
            else
            {
                g.DrawString("GameOver", new Font(FontFamily.GenericSerif, 20), Brushes.Black, new PointF(200f, 100f));
            }
            
            this.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                case Keys.Left:
                    if (basketPosition - 1 >= 1)
                    {
                        basketPosition--;
                        Invalidate();
                    }
                    break;
                case Keys.D:
                case Keys.Right:
                    if (basketPosition + 1 < 8)
                    {
                        basketPosition++;
                        Invalidate();
                    }
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Apfel item in Äpfel)
            {
                bool b = item.Move();
                if (!b)
                {
                    if (basketPosition == item.Position)
                    {
                        Äpfel.Remove(item);
                        Punkte += 100;
                        break;
                    }
                    else
                    {
                        GameOver = true;
                    }
                }
                else
                {
                    
                }
            }
            Invalidate();
        }

        

        private void CreateRandomApfel()
        {
            Random rnd = new Random();
            int position = rnd.Next(1, 8);

            Äpfel.Add(new Apfel(position, startRectangleTop + LineTop + 220, 6, startRectangleLeft + LineLeft * position, startRectangleTop + LineTop));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //äpfelAdd.Suspend();
            äpfelAdd.Abort();
            äpfelAdd.Join();
            timer1.Stop();
        }
    }
}
