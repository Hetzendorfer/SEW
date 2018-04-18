using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace RDP_1112_A3
{
    class Server
    {

        private TcpListener Listener;
        private Thread AcceptingClients;
        private Thread ReadFromConsole;

        public bool IsRunning { get; private set; }

        private int _AnzahlThreads;
        public int AnzahlThreads {
            get
            {
                return _AnzahlThreads;
            }
            set
            {
                if (value > 0)
                    _AnzahlThreads = value;
                else
                    throw new Exception("AnzahlThreads is not a positive number");
            }
        }

        public List<Thread> ThreadList { get; set; }
        public Dictionary<int, Game> GameList { get; set; }

        public Server(int port, int anzahlThreads)
        {
            this.AnzahlThreads = anzahlThreads;
            this.ThreadList = new List<Thread>();
            this.GameList = new Dictionary<int, Game>();

            this.Listener = new TcpListener(new System.Net.IPEndPoint(IPAddress.Any, port));
        }

        public void Start()
        {
            this.Listener.Start();

            this.AcceptingClients = new Thread(SearchNewClients);
            this.ReadFromConsole = new Thread(ReadUserInput);

            PaintConsole();
            this.AcceptingClients.Start();
            this.ReadFromConsole.Start();

            this.IsRunning = true;
            
        }

        public void ReadUserInput()
        {
            while (true)
            {
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.WriteLine(this.GetStatistics());
                        break;
                    case "E":
                        if (this.Close())
                        {
                            Console.WriteLine("Server is closing ....");
                            this.IsRunning = false;
                        }
                        break;
                    case "clear":
                        this.PaintConsole();
                        break;
                    default:
                        break;

                }
            }
        }

        public string GetStatistics()
        {
            string s = "";
            foreach (KeyValuePair<int, Game> item in this.GameList)
                s += item.Value.ToString();
            if (s == "")
                s = "Keine Statistiken verfügbar\r\n";
            return s;
        }

        public void PaintConsole()
        {
            Console.Clear();

            Console.WriteLine("1 .... Aktuelle Statistik ausgeben");
            Console.WriteLine("E .... Server beenden");
            Console.WriteLine("----------------------------------");
        }

        public bool Close()
        {
            try
            {
                foreach (Thread item in this.ThreadList)
                    item.Abort();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void SearchNewClients()
        {
            try
            {
                while (true)
                {
                    Socket soc = this.Listener.AcceptSocket();
                    if (this.ThreadList.Count < this.AnzahlThreads)
                    {
                        Thread connection = new Thread(() =>
                        {
                            Socket accepted = soc;
                            while (true)
                            {
                                byte[] Buffer;
                                Buffer = new byte[accepted.SendBufferSize];
                                int bytesRead = accepted.Receive(Buffer);
                                byte[] formatted = new byte[bytesRead];
                                for (int i = 0; i < bytesRead; i++)
                                {
                                    formatted[i] = Buffer[i];
                                }

                                string strData = Encoding.ASCII.GetString(formatted);
                                if (strData != "")
                                {
                                    accepted.Send(Encoding.ASCII.GetBytes(this.AcceptData(strData)));
                                }
                            }
                        });
                        this.ThreadList.Add(connection);
                        connection.Start();
                    }

                }
            }
            catch(ThreadAbortException ex)
            {
                throw ex;
            }
            
        }

        private string AcceptData(string s)
        {
            try
            {
                XDocument doc = XDocument.Parse(s);
                XElement gameID = doc.Descendants("GAMEID").Single();
                Game g = null;
                bool correct = false;

                string response = "";

                if (gameID.Value == "")
                    g = this.NewGame();

                else
                {
                    foreach (KeyValuePair<int, Game> item in this.GameList)
                        if (item.Key.ToString() == gameID.Value)
                        {
                            g = item.Value;
                            break;
                        }

                    g.IncreaseRequestCount();

                    Question q = g.QuestionList[g.QuestionList.Count - 1];
                    int answerSelected;
                    string answer = doc.Descendants("ANSWERID").Single().Value;
                    if (answer != "")
                    {
                        answerSelected = Convert.ToInt32(answer);
                        q.Answered = answerSelected + 1;

                        correct = q.AnswerList[answerSelected].Correct;
                        g.QuestionList[g.QuestionList.Count - 1] = q;
                    }
                    else
                    {
                        s = GetQuestionForGame(g);
                    }
                }

                if (correct)
                {
                    response = $"<RESPONSE><ID>{g.RequestCount}</ID><GAMEID>{g.GameID}</GAMEID><CORRECT>{correct}</CORRECT></RESPONSE>";
                    if (g.Level == 2)
                        g.End();
                    g.Level++;
                }
                return GetQuestionForGame(g);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }

        private string GetQuestionForGame(Game g)
        {
            Question q = null;
            List<Answer> answerList = new List<Answer>();
            switch (g.Level)
            {
                case 0:
                    answerList.Add(new Answer("1", false));
                    answerList.Add(new Answer("2", true));
                    answerList.Add(new Answer("3", false));
                    answerList.Add(new Answer("4", false));
                    q = new Question("Was ergibt 1 + 1?", answerList, 0);
                    break;
                case 1:
                    answerList.Add(new Answer("Herz", true));
                    answerList.Add(new Answer("Leber", false));
                    answerList.Add(new Answer("Darm", false));
                    answerList.Add(new Answer("Gehirn", false));
                    q = new Question("Was ist das wichtigste Organ eines Menschen?", answerList, 1);
                    break;
                case 2:
                    answerList.Add(new Answer("keine AHnung", false));
                    answerList.Add(new Answer("Hä was willst du von mir?", false));
                    answerList.Add(new Answer("3", false));
                    answerList.Add(new Answer("1.1233", true));
                    q = new Question("Quadratwurzel von Pi?", answerList, 2);
                    break;
                default:
                    break;
            }
            g.QuestionList.Add(q);

            string s = $"<RESPONSE><ID>{g.RequestCount}</ID><GAMEID>{g.GameID}</GAMEID><LEVEL>{g.Level}</LEVEL><QUESTION>{q.Text}</QUESTION><ANSWER1>{answerList[0].Text}</ANSWER1>" +
                $"<ANSWER2>{answerList[1].Text}</ANSWER2><ANSWER3>{answerList[2].Text}</ANSWER3><ANSWER4>{answerList[3].Text}</ANSWER4></RESPONSE>";
            return s;


        }

        private Game NewGame()
        {
            int gameID = 1;
            if (this.GameList.Keys.Count != 0)
                gameID = this.GameList.Keys.Max() + 1;
            Game newGame = new Game(gameID);
            this.GameList.Add(gameID, newGame);

            return newGame;
        }
    }
}
