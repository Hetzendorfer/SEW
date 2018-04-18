using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_1112_A3
{
    public class Question
    {
        public string Text { get; private set; }
        public List<Answer> AnswerList { get; private set; }
        public int Level { get; private set; }

        public int Answered { get; set; } = 0;

        public Question(string txt, List<Answer> liste, int level)
        {
            this.Text = txt;
            this.AnswerList = liste;
            this.Level = level;
        }

        public override string ToString()
        {
            string s = "Frage: " + this.Text + "\r\n";

            List<string> st = new List<string>();

            foreach (Answer item in this.AnswerList)
                st.Add(item.ToString());

            string[] arr = st.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                s += "\t";
                if (this.Answered == i + 1)
                    s += "*";
                else
                    s += " ";
                s += arr[i] + "\n\r";
            }

            return s;
        }
    }
}
