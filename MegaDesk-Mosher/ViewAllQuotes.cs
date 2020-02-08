using System;
using System.Windows.Forms;

namespace MegaDesk_Mosher
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            // If there are no quotes to load, display a message to the user letting them know
            if (DeskQuote.listOfQuotes.Count == 0)
            {
                MessageBox.Show("No quotes are available to view");
            }

            dataGridView1.DataSource = DeskQuote.listOfQuotes;
        }

        // Button for closing the form
        private void CloseFormButton_Click(object sender, EventArgs e)
        {

            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
