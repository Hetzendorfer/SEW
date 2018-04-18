using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_1112_A3
{
    public class Answer
    {
        public string Text { get; private set; }
        public bool Correct { get; private set; }

        public Answer(string txt, bool correct)
        {
            this.Text = txt;
            this.Correct = correct;
        }

        public override string ToString()
        {
            string s = this.Text;

            return s;
        }
    }
}
