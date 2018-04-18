using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_1112_A3
{
    public class Game
    {
        public int GameID { get; private set; }
        public int RequestCount { get; private set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        private int _Level;
        public int Level
        {
            get { return _Level; }
            set
            {
                if (value <= 2 && value >= 0)
                    _Level = value;
                else
                    throw new Exception("New value exceeds the values possible for a Level.");
            }
        }

        public List<Question> QuestionList { get; set; }

        public Game(int gameid)
        {
            this.GameID = gameid;
            this.RequestCount = 1;

            this.BeginDate = DateTime.Now;
            this.QuestionList = new List<Question>();
        }

        public void IncreaseRequestCount()
        {
            this.RequestCount++;
        }
        public void IncreaseRequestCount(int i)
        {
            this.RequestCount += i;
        }

        public void End()
        {
            this.EndDate = DateTime.Now;
        }

        public override string ToString()
        {
            string s = $"Game #{this.GameID} - im Level: {this.Level}\r\n";
            s += this.BeginDate.ToLongTimeString() + "\r\n \r\n";

            foreach (Question item in this.QuestionList)
                s += item.ToString() + "\r\n";

            s += this.EndDate.ToLongTimeString();


            return s;
        }

    }
}
