using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Mosher
{
    public partial class SearchQuotes : Form
    {
        public string Material { get; set; }
        public SearchQuotes()
        {
            InitializeComponent();



            // If there are no quotes to load, display a message to the user letting them know
            if (DeskQuote.listOfQuotes.Count == 0)
            {
                MessageBox.Show("No quotes are available to view");
            }

            // This will load quotes from the list while the program is running
            var list = new BindingList<DeskQuote>(DeskQuote.listOfQuotes);

        }


        private void CloseFormButton_Click(object sender, EventArgs e)
        {

            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            DeskQuote.MaterialQuotes.Clear();

            for (int i = 0; i < DeskQuote.listOfQuotes.Count; i++)
            {


                String FName = DeskQuote.listOfQuotes[i].clientFirstName.ToString();
                String LName = DeskQuote.listOfQuotes[i].clientLastName.ToString();
                Double QTotal = DeskQuote.listOfQuotes[i].quoteTotal;
                String QMaterial = DeskQuote.listOfQuotes[i].Material.ToString();
                String SDate = DeskQuote.listOfQuotes[i].submitDate.ToString();

                List<String> materialQuotes = new List<String>();


                if (DeskQuote.listOfQuotes[i].Material == materialBox.Text)
                {
                    DeskQuote quoteInfo = new DeskQuote(FName, LName, QTotal, QMaterial, SDate);
                    DeskQuote.MaterialQuotes.Add(quoteInfo);
                    //dataGridView1.DataSource = DeskQuote.listOfQuotes[i];

                }

            }
            // Create a BindingSource, and attach the list to it.  Then it will refresh each time you click this button

            source.DataSource = DeskQuote.MaterialQuotes;
            dataGridView1.DataSource = source;
        }

        private void test2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void testbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
