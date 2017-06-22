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
            dataGridViewLager.DataSource = dsLager;
            dataGridViewLager.DataMember = "Lager";

        }

        private void button_zuruck_lagerverwaltung_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
