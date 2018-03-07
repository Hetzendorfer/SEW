using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaktion
{
    public struct Geld
    {
        public decimal Menge { get; set; }

        public Geld(decimal menge)
        {
            this.Menge = menge;
        }

        public static Geld operator +(Geld g1, Geld g2) => new Geld(g1.Menge + g2.Menge);

        public static implicit operator Geld(decimal menge)
        {
            Geld geld = new Geld(menge);
            return geld;
        }        public static explicit operator decimal(Geld geld)
        {
            return geld.Menge;
        }
    }
}
