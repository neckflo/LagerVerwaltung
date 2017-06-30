using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LagerVerwaltung
{
    public partial class hinzufuegen : Form
    {
        OleDbConnection con = null;
        Produkt newProdukt = null;
        public hinzufuegen()
        {
            InitializeComponent();
        }
        public OleDbConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }
        public hinzufuegen(OleDbConnection connection):this()
        {
            this.con = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        internal Produkt NewProdukt
        {
            get
            {
                return newProdukt;
            }


        }

        private void button_hinzufuegenartikel_Click(object sender, EventArgs e)
        {
            Produkt aProdukt = new Produkt();
            //aProdukt.Nummer = Convert.ToInt32(textBox_nummer.Text);
        
            aProdukt.Name = textBox_name.Text;
            aProdukt.Bezeichnung = textBox_bezeichnung.Text;
            aProdukt.Bestand = Convert.ToInt32(textBox_bestand.Text);
            aProdukt.Lagerort = Convert.ToInt32(textBox_lagerort.Text);
            aProdukt.Preis = Convert.ToInt32(textBox_preis.Text);
            insertDB(aProdukt);
            newProdukt = aProdukt;
        }
        private void insertDB(Produkt aProdukt)
        {
            OleDbCommand cmd = con.CreateCommand();
            //Autowert
            cmd.CommandText = "SELECT @@identity From lager";
            try
            {

                Int32 auto = (Int32)cmd.ExecuteScalar();
                auto++;
                aProdukt.Nummer = auto;
                textBox_nummer.Text = auto.ToString();

            }
            catch (Exception)
            {

  
            }


           
            //cmd.CommandText = "Insert into lager (Nummer,Name,Bezeichnung,Bestand,Lagerort) Values ("+aProdukt.Nummer+","+aProdukt.Name","+aProdukt.Bezeichnung+","+aProdukt.Bestand+","+aProdukt.Lagerort+")";
            cmd.Parameters.Add("NR", OleDbType.Integer);
            cmd.Parameters.Add("NAM", OleDbType.WChar);
            cmd.Parameters.Add("BEZ", OleDbType.WChar);
            cmd.Parameters.Add("BES", OleDbType.Integer);
            cmd.Parameters.Add("LO", OleDbType.Integer);
            cmd.Parameters.Add("PR", OleDbType.Integer);
            cmd.CommandText = "Insert into lager (artikelnummer,artikelname,beschreibung,bestand,lagerort,preis) Values (NR,NAM,BEZ,BES,LO,PR)";

            //Values
            cmd.Parameters["NR"].Value = aProdukt.Nummer;
            cmd.Parameters["NAM"].Value = aProdukt.Name;
            cmd.Parameters["BEZ"].Value = aProdukt.Bezeichnung;
            cmd.Parameters["BES"].Value = aProdukt.Bestand;
            cmd.Parameters["LO"].Value = aProdukt.Lagerort;
            cmd.Parameters["PR"].Value = aProdukt.Preis;
            //Ausführen
            try
            {                 
                int anzahl = cmd.ExecuteNonQuery();
                MessageBox.Show(anzahl.ToString() + " Produkt eingefügt.");
                textBox_name.Clear();
                textBox_nummer.Clear();
                textBox_bezeichnung.Clear();
                textBox_bestand.Clear();
                textBox_lagerort.Clear();
                textBox_preis.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Einfügen nicht erfolgreich");
            }
                    
        }

        private void textBox_nummer_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_nummer.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox_bezeichnung_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox_bestand_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_bestand.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }

        private void textBox_lagerort_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_lagerort.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }


        private void textBox_preis_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_preis.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
