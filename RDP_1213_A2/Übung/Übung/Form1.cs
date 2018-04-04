using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Übung.data;

namespace Übung
{
    public partial class Form1 : Form
    {
        List<Patient> PatientenXml = null;
        List<Patient> PatientenSql = null;
        public Form1()
        {
            InitializeComponent();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "xml files (*.xml)|*.xml";

            /*Patient p = new Patient(8, "Hetzendorfer", "Kevin", "123456");
            Behandlung b = new Behandlung("Kur", 100, DateTime.Now);
            p.Behandlungen.Add(b);
            Datenbank db = Datenbank.GetInstance();
            db.Open();
            p.SaveToDB(db);
            db.Close(); */
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            foreach (Patient item in PatientenXml)
            {
                item.SaveToDB(Datenbank.GetInstance());
            }
            PatientenSql = SQL.ReadPatienten();
            Kennzahlen(1);

            TransferStatus();
        }
        private void TransferStatus()
        {
            if(xmlSumPatientenTextBox.Text == sqlSumPatientenTextBox.Text &&
            xmlSumBehandlungTextBox.Text == sqlSumBehandlungTextBox.Text &&
            xmlDifferentBehandlungTextBox.Text == sqlDifferentBehandlungTextBox.Text &&
            xml1BehandlungTextBox.Text == sql1BehandlungTextBox.Text &&
            xml2BehandlungTextBox.Text == sql2BehandlungTextBox.Text &&
            xmlMehr2BehandlungTextBox.Text == sqlMehr2BehandlungTextBox.Text &&
            xmlSumTherapiezeitTextBox.Text == sqlSumTherapiezeitTextBox.Text)
            {
                MessageBox.Show("Transfer wurde erfolgreich abgeschlossen!");
            }
            else
            {
                MessageBox.Show("Es traten Probleme auf");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                PatientenXml = XML.ReadFromFile(openFileDialog.FileName);
            if(PatientenXml != null)
            {
                Kennzahlen(0);
            }
        }

        private void ListFromDB()
        {
            PatientenSql = SQL.ReadPatienten();
        }

        private void Kennzahlen(int anzeige)
        {
            List<Patient> Patienten = anzeige == 0 ? PatientenXml : PatientenSql;

            int anzahlPatienten = Patienten.Count;
            int anzahlBehandlungen = 0;
            List<string> differentBehandlungen = new List<string>();
            int Behandlung1 = 0;
            int Behandlung2 = 0;
            int BehandlungMehr2 = 0;
            int summeTherapie = 0;

            foreach (Patient item in Patienten)
            {
                int i = item.Behandlungen.Count;
                anzahlBehandlungen += i;
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        Behandlung1++;
                        break;
                    case 2:
                        Behandlung2++;
                        break;
                    default:
                        BehandlungMehr2++;
                        break;
                }

                foreach (Behandlung behandlung in item.Behandlungen)
                {
                    if (!differentBehandlungen.Contains(behandlung.Bezeichnung))
                        differentBehandlungen.Add(behandlung.Bezeichnung);
                    summeTherapie += behandlung.Dauer;
                }
            }

            if(anzeige == 0)
            {
                xmlSumPatientenTextBox.Text = anzahlPatienten.ToString();
                xmlSumBehandlungTextBox.Text = anzahlBehandlungen.ToString();
                xmlDifferentBehandlungTextBox.Text = differentBehandlungen.Count.ToString();
                xml1BehandlungTextBox.Text = Behandlung1.ToString();
                xml2BehandlungTextBox.Text = Behandlung2.ToString();
                xmlMehr2BehandlungTextBox.Text = BehandlungMehr2.ToString();
                xmlSumTherapiezeitTextBox.Text = summeTherapie.ToString();
            }
            else
            {
                sqlSumPatientenTextBox.Text = anzahlPatienten.ToString();
                sqlSumBehandlungTextBox.Text = anzahlBehandlungen.ToString();
                sqlDifferentBehandlungTextBox.Text = differentBehandlungen.Count.ToString();
                sql1BehandlungTextBox.Text = Behandlung1.ToString();
                sql2BehandlungTextBox.Text = Behandlung2.ToString();
                sqlMehr2BehandlungTextBox.Text = BehandlungMehr2.ToString();
                sqlSumTherapiezeitTextBox.Text = summeTherapie.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SQL.DeleteAll())
                MessageBox.Show("Inhalte aller Tabellen wurden gelöscht");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Datenbank.GetInstance().Close();
        }
    }
}
