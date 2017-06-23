using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagerVerwaltung
{
    public partial class hinzufuegen : Form
    {
        public hinzufuegen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_hinzufuegenartikel_Click(object sender, EventArgs e)
        {
            Int32 nummer;
            string name;
            string bezeichnung;
            Int32 bestand;
            Int32 lagerort;
            


            // Try catch wegen falscheingabe

            bestand = Convert.ToInt32(textBox_bestand.Text);
            lagerort = Convert.ToInt32(textBox_lagerort.Text);
            nummer = Convert.ToInt32(textBox_nummer.Text);
            name = textBox_name.Text;
            bezeichnung = textBox_bezeichnung.Text;
        }
    }
}
