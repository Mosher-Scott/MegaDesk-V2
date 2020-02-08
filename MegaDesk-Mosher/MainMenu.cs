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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            // Read the savedquotes file on program load. 
            DeskQuote.readSavedQuotesFiles();

            // Check if the rushOrderPrices.txt file exists
            DeskQuote.checkIfRushorderPriceExists();
        }

        private void ViewAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteWindow = new AddQuote();

            viewAddQuoteWindow.Tag = this;
            viewAddQuoteWindow.Show(this);

            // Hide the current window
            Hide();

        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuoteWindow = new SearchQuotes();

            viewSearchQuoteWindow.Tag = this;
            viewSearchQuoteWindow.Show(this);

            // Hide the window
            Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesWindow = new ViewAllQuotes();

            viewAllQuotesWindow.Tag = this;
            viewAllQuotesWindow.Show(this);

            // Hide the window
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Are you sure you want to exit?");
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
