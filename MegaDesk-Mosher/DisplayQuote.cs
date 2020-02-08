using System;
using System.Windows.Forms;

namespace MegaDesk_Mosher
{
    public partial class DisplayQuoteInfo : Form
    {
        // Create an empty desk object.  Will populate it when the form loads in the DisplayQuoteInfo() section
        private Desk userDesk = new Desk();

        // Create some variables to hold the incoming info
        private string quoteFirstName;
        private string quoteLastName;
        private double quoteWidth;
        private double quoteDepth;
        private int quoteDrawers;
        private string quoteMaterial;
        private int quoteRushInfo;

        // Initializes the form with data coming from the AddQuote form
        public DisplayQuoteInfo(string firstName, string lastName, double width, double depth, int drawers, string material, int rushOrderInfo)
        {

            InitializeComponent();

            quoteFirstName = firstName;
            quoteLastName = lastName;
            quoteWidth = width;
            quoteDepth = depth;
            quoteDrawers = drawers;
            quoteMaterial = material;
            quoteRushInfo = rushOrderInfo;

            // Set the values on the form with the desk size/material info

            OrderInfoLabel.Text = $"Quote For {firstName} {lastName}";
            widthValue.Text = $"{width.ToString()}\"";
            DepthValue.Text = $"{depth.ToString()}\"";
            DrawersValue.Text = drawers.ToString();
            SurfaceValue.Text = material;
            RushValue.Text = rushOrderInfo.ToString();

            // Create a desk object so we can use it
            userDesk.deskWidth = width;
            userDesk.deskDepth = depth;
            userDesk.numDrawers = drawers;
            userDesk.surfaceMaterial = material;
            userDesk.rushOption = rushOrderInfo;

            // Display pricing
            BasePriceValue.Text = $"${Desk.BASEPRICE.ToString()}";
            ExtraSpaceValue.Text = $"${userDesk.getSurfaceAreaCost().ToString()}";
            DrawersPriceValue.Text = $"${userDesk.getDrawerCost().ToString()}";
            MaterialPriceValue.Text = $"${userDesk.getSurfaceMaterialCost().ToString()}";
            RushOrderValue.Text = $"${userDesk.getRushOrderPrice().ToString()}";

            // Get total price & display it
            TotalPriceValue.Text = $"${userDesk.getTotalCost().ToString()}";
        }

        // Close the form and return back to the Main Menu
        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        // Close this form, and return to the Add Quote screen
        private void ReturnToAddQuoteScreenLabel_Click(object sender, EventArgs e)
        {

            AddQuote addQuoteForm = (AddQuote)Tag;
            addQuoteForm.Show();

            // Close the window
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        // This will run when the user wants to save a quote
        private void SaveQuote()
        {
  
            DateTime currentDate = DateTime.Now;

            // Create a quote object
            DeskQuote quoteInfo = new DeskQuote(quoteFirstName, quoteLastName, currentDate.ToString("MM/dd/yyyy H:mm tt"), userDesk.getTotalCost(), quoteMaterial, userDesk);

            // Add the quote to a list of quotes
            DeskQuote.listOfQuotes.Add(quoteInfo);

            // Now write the quote to file
            quoteInfo.convertListToJson();

            MessageBox.Show("Quote Saved");
        }

        // This runs when the user saves a quote and wants to go back to the Main menu
        private void SaveQuoteButton_Click(object sender, EventArgs e)
        {

            SaveQuote();

            MainMenu mainMenuForm = new MainMenu();

            mainMenuForm.Show();

            Close();
        }


        private void SurfaceValue_Click(object sender, EventArgs e)
        {
        
        }

        // This will run when the user clicks the Save & New button
        private void SaveAndNewButton_Click(object sender, EventArgs e)
        {
            SaveQuote();

            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();

            // Close the window
            this.Close();
        }
    }
}
