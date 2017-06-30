using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LagerVerwaltung
{
    public partial class Form1 : Form 
    {
        DataSet dslager;
        OleDbConnection con;
        OleDbDataAdapter adpLager = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;

        anzeigen anz;
        hinzufuegen hin;




        public Form1()
        {
            InitializeComponent();
            if (!WBEmulator.IsBrowserEmulationSet())
            {
                WBEmulator.SetBrowserEmulationVersion();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_verbinden_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(Properties.Settings.Default.DBCon);
            try
            {
                con.Open();

                label_meldung.Text = "Verbindung erfolgreich!";
                label_meldung.ForeColor = System.Drawing.Color.Green;
            }
            catch (OleDbException)
            {
                label_meldung.Text = "Verbindung fehlgeschlagen!";
                label_meldung.ForeColor = System.Drawing.Color.Red;
            }
            button4.Enabled = true;
            button_hinzufugen.Enabled = true;
            button_trennen.Enabled = true;



        }

        private void button4_Click(object sender, EventArgs e) // button anzeigen
        {
             anz = new anzeigen();
             anz.ShowDialog();
            
        }

        private void button_hinzufugen_Click(object sender, EventArgs e)
        {
            hin = new hinzufuegen(con);
            hin.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_trennen_Click(object sender, EventArgs e)
        {
            con.Close();
            button4.Enabled = false;
            button_hinzufugen.Enabled = false;
            button_trennen.Enabled = false;

            label_meldung.Text = "";

        }
    }
}
