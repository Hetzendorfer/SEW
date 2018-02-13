using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            config.DBConnection dBConnection = config.DBConnection.Instance();
            dBConnection.Username = "root";
            dBConnection.Password = "";
            dBConnection.DatabaseName = "rechnung";

            FillListBox();
        }

        private void FillListBox()
        {
            config.DBConnection dBConnection = config.DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = "SELECT rechnung.ID FROM rechnung;";
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.listBox1.Items.Add(reader.GetInt32(0));
                    }
                    dBConnection.Close();
                }
                catch (Exception e)
                {

                }
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem is null))
            {
                config.Rechnung rechnung = new config.Rechnung(Convert.ToInt32(this.listBox1.SelectedItem));

                //Make PDF
                pdf.PDF.CreatePDF(rechnung);
            }
        }
    }
}
