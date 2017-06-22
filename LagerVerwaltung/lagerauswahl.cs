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
    public partial class lagerauswahl : Form
    {

        
        public lagerauswahl()
        {
            InitializeComponent();
            comboBox1.Items.Add("Würzburg");
            comboBox1.Items.Add("Hamburg");
            comboBox1.Items.Add("Stuttgart");
            comboBox1.Items.Add("München");
            comboBox1.Items.Add("Berlin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            karteanzeigen();
        }
        private void karteanzeigen()
        {
            string ort = comboBox1.SelectedItem.ToString();

            try
            {

                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://maps.google.com/maps?q=");

                if (ort != string.Empty)
                {
                    queryaddress.Append(ort);
                }


                webBrowser1.Navigate(queryaddress.ToString());
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            karteanzeigen();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
    
}
