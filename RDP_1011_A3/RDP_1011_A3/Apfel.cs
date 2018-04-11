using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_1011_A3
{
    class Apfel
    {
        public int Position { get;}
        public int X { get; set; }
        public int Y { get; set; }
        public int FinishY { get; set; }
        public int MoveY { get; set; }

        public Apfel(int position, int finishY, int moveY, int x, int y)
        {
            this.Position = position;
            this.X = x;
            this.Y = y;
            this.FinishY = finishY;
            this.MoveY = moveY;
        }

        public bool Move()
        {
            if (this.Y + this.MoveY > this.FinishY)
                return false;
            else
            {
                this.Y += this.MoveY;
                return true;
            }
        }
    }
}
