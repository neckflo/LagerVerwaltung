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
    public partial class anzeigen : Form
    {
        DataSet dsLager;
        OleDbConnection con;
        OleDbDataAdapter adpLager = null;
        lagerauswahl lageraus;



        public anzeigen()
        {
            InitializeComponent();
            con = new OleDbConnection(Properties.Settings.Default.DBCon);
            adpLager = new OleDbDataAdapter("select * from lager", con);
            dsLager = new DataSet();
            datenAnzeigen();
            comboBox1.Items.Add("Würzburg");
            comboBox1.Items.Add("Hamburg");
            comboBox1.Items.Add("Stuttgart");
            comboBox1.Items.Add("München");
            comboBox1.Items.Add("Berlin");
            comboBox1.Items.Add("gesamt");



        }

        private void verbinden()
        {
            try
            {
                con = new OleDbConnection(Properties.Settings.Default.DBCon);
            }
            catch (Exception)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void datenAnzeigen()
        {

            try
            {
                adpLager.Fill(dsLager, "Lager");
                dataGridViewLager.DataSource = dsLager;
                dataGridViewLager.DataMember = "Lager";


            }
            catch (Exception)
            {
                MessageBox.Show("Daten konnten nicht geladen werden!");
            }

        }

        private void button_anzeigen_lagerverwaltung_Click(object sender, EventArgs e)
        {
            //dataGridViewLager.DataSource = dsLager;
            //dataGridViewLager.DataMember = "Lager";

            //con = new OleDbConnection(Properties.Settings.Default.DBCon);
            //adpLager = new OleDbDataAdapter("select * from lager where lagerort = 1", con);
            //dsLager = new DataSet();
            //datenAnzeigen();

        }

        private void button_zuruck_lagerverwaltung_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Daten Sichern
        {
            OleDbCommandBuilder b = new OleDbCommandBuilder(adpLager);
            adpLager.UpdateCommand = b.GetUpdateCommand();

            adpLager.InsertCommand = b.GetInsertCommand();

            adpLager.DeleteCommand = b.GetDeleteCommand();

            adpLager.Update(dsLager, "Lager");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lageraus = new lagerauswahl();
            lageraus.ShowDialog();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int lager = comboBox1.SelectedIndex;

            dataGridViewLager.Columns.Clear();
            dsLager = new DataSet();
            if (lager == 0)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 1", con);
                datenAnzeigen();
            }
            if (lager == 1)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 2", con);
                datenAnzeigen();
            }
            if (lager == 2)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 3", con);
                datenAnzeigen();
            }
            if (lager == 3)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 4", con);
                datenAnzeigen();
            }
            if (lager == 4)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 5", con);
                datenAnzeigen();
            }
            if (lager == 5)
            {
                adpLager = new OleDbDataAdapter("select * from lager", con);
                datenAnzeigen();
            }





        }
    }
}