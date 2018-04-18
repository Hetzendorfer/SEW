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
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket soc;
        int requestnumber = 1;
        int gameID = 0;

        public Form1()
        {
            InitializeComponent();

            soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1333);

            try
            {
                soc.Connect(localEndPoint);
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            gameID = 0;
            requestnumber = 1;
            try
            {
                string txt = $"<REQUEST><ID> {this.requestnumber} </ID><GAMEID></GAMEID><ANSWERID></ANSWERID></REQUEST>";
                byte[] data = Encoding.ASCII.GetBytes(txt);

                soc.Send(data);
                byte[] receivedData = new byte[5000];
                soc.Receive(receivedData);
                txt = Encoding.ASCII.GetString(receivedData).Replace("\0", "");
                MessageBox.Show(txt);

                XDocument doc = XDocument.Parse(txt);
                gameID = Convert.ToInt32(doc.Descendants("GAMEID").Single().Value);
                frage.Text = doc.Descendants("QUESTION").Single().Value;
                antwort1.Text = doc.Descendants("ANSWER1").Single().Value;
                antwort2.Text = doc.Descendants("ANSWER2").Single().Value;
                antwort3.Text = doc.Descendants("ANSWER3").Single().Value;
                antwort4.Text = doc.Descendants("ANSWER4").Single().Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            soc.Dispose();
        }

        private void antwort1_Click(object sender, EventArgs e)
        {
            SendAndReceive(0);
        }

        private void antwort2_Click(object sender, EventArgs e)
        {
            SendAndReceive(1);
        }

        private void antwort3_Click(object sender, EventArgs e)
        {
            SendAndReceive(2);
        }

        private void antwort4_Click(object sender, EventArgs e)
        {
            SendAndReceive(3);
        }

        private void SendAndReceive(int antwort)
        {
            try
            {
                string txt = $"<REQUEST><ID> {this.requestnumber + 1} </ID><GAMEID>{this.gameID}</GAMEID><ANSWERID>{antwort}</ANSWERID></REQUEST>";
                byte[] data = Encoding.ASCII.GetBytes(txt);

                soc.Send(data);
                byte[] receivedData = new byte[5000];
                soc.Receive(receivedData);
                txt = Encoding.ASCII.GetString(receivedData).Replace("\0", "");

                XDocument doc = XDocument.Parse(txt);
                gameID = Convert.ToInt32(doc.Descendants("GAMEID").Single().Value);
                if (doc.Descendants("LEVEL").Count() != 0)
                {
                    frage.Text = doc.Descendants("QUESTION").Single().Value;
                    antwort1.Text = doc.Descendants("ANSWER1").Single().Value;
                    antwort2.Text = doc.Descendants("ANSWER2").Single().Value;
                    antwort3.Text = doc.Descendants("ANSWER3").Single().Value;
                    antwort4.Text = doc.Descendants("ANSWER4").Single().Value;
                }
                else
                {
                    bool b = Convert.ToBoolean(doc.Descendants("CORRECT").Single().Value);
                    MessageBox.Show("Answer was " + b);
                    SendAndReceiveQuestion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SendAndReceiveQuestion()
        {
            try
            {
                string txt = $"<REQUEST><ID> {this.requestnumber + 1} </ID><GAMEID>{this.gameID}</GAMEID><ANSWERID></ANSWERID></REQUEST>";
                byte[] data = Encoding.ASCII.GetBytes(txt);

                soc.Send(data);
                byte[] receivedData = new byte[5000];
                soc.Receive(receivedData);
                txt = Encoding.ASCII.GetString(receivedData).Replace("\0", "");

                XDocument doc = XDocument.Parse(txt);
                gameID = Convert.ToInt32(doc.Descendants("GAMEID").Single().Value);
                frage.Text = doc.Descendants("QUESTION").Single().Value;
                antwort1.Text = doc.Descendants("ANSWER1").Single().Value;
                antwort2.Text = doc.Descendants("ANSWER2").Single().Value;
                antwort3.Text = doc.Descendants("ANSWER3").Single().Value;
                antwort4.Text = doc.Descendants("ANSWER4").Single().Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
