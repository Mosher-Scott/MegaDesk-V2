﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MegaDesk_Mosher
{

    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
        }

        // Code for what to do when the user wants to go back to the main menu
        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {

            MainMenu viewMainMenu =  new MainMenu();
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        // Hiding all the methods that are empty
        #region

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void CustomerNameInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeskHeightInputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matValue_Click(object sender, EventArgs e)
        {

        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        #endregion

        // ---- This section contains the popup messages
        #region
        private void textBox1_PopupMessage(object sender, EventArgs e)
        {
            ToolTip deskWidthMessage = new ToolTip();
            deskWidthMessage.ShowAlways = true;
            deskWidthMessage.IsBalloon = true;
            deskWidthMessage.SetToolTip(DeskWidthInputBox, "Min 24\",  Max 96\"");
        }

        private void DesktopHeightInputBox_PopupMessage(object sender, EventArgs e)
        {
            ToolTip deskWidthMessage = new ToolTip();
            deskWidthMessage.ShowAlways = true;
            deskWidthMessage.IsBalloon = true;
            deskWidthMessage.SetToolTip(DeskDepthtInputBox, "Min 12\",  Max 48\"");
        }

        private void NumberOfDrawersInputBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip numberOfDrawersMessage = new ToolTip();
            numberOfDrawersMessage.ShowAlways = true;
            numberOfDrawersMessage.IsBalloon = true;
            numberOfDrawersMessage.SetToolTip(NumberOfDrawersInputBox, "Min 0, Max 7");
        }

        /* Taking out hover event for old Material Box -TS
        private void SurfaceMaterialInputBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip surfaceMaterialMessage = new ToolTip();
            surfaceMaterialMessage.ShowAlways = true;
            surfaceMaterialMessage.IsBalloon = true;
            surfaceMaterialMessage.SetToolTip(SurfaceMaterialInputBox, "Laminate, oak, Rosewood, Veneer, Pine");
        }
        */

        private void RushOrderInputBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip rushOrderMessage = new ToolTip();
            rushOrderMessage.ShowAlways = true;
            rushOrderMessage.IsBalloon = true;
            //rushOrderMessage.SetToolTip(RushOrderInputBox, "3, 5, 7, or 14 Days (Normal Production)");
        }
        #endregion

        // When the person fills in the all the fields and clicks the Generate Quote button, this will run
        private void GenerateQuote(object sender, EventArgs e)
        {         

            // Validate First name field
            if (string.IsNullOrWhiteSpace(CustomerNameInputBox.Text))
            {
                MessageBox.Show("Error.  First name is Empty");
            }

            // Validate Last Name Field
            if (string.IsNullOrWhiteSpace(CustomerNameInputBox.Text))
            {
                MessageBox.Show("Error.  Last name is Empty");
            }

            // Validate width Field
            if (string.IsNullOrWhiteSpace(DeskWidthInputBox.Text))
            {
                MessageBox.Show("Error.  Width is Empty");
            }

            // Validate depth Field
            if (string.IsNullOrWhiteSpace(DeskDepthtInputBox.Text))
            {
                MessageBox.Show("Error.  Depth is Empty");
            }

            // Validate depth Field
            if (string.IsNullOrWhiteSpace(NumberOfDrawersInputBox.Text))
            {
                MessageBox.Show("Error.  Number of Drawers is Empty");
            }

            //Check if the material drop down has a value -TS
            if (materialBox.Text == "")
            {
            // Validation message. 
            errorProvider1.SetError(materialBox, "Material Selection Required.");
            matRequired.Text = " -Required";

            }

            // If no validation errors, create the quote
            else
            {
                int rushOrderOption;

                //set Rush Day to Value
                if (RushRadioNone.Checked)
                {
                    rushOrderOption = 0;
                }
                else if (RushRadioThree.Checked)
                {
                    rushOrderOption = 3;
                }
                else if (RushRadioFive.Checked)
                {
                    rushOrderOption = 5;
                }
                else if (RushRadioSeven.Checked)
                {
                    rushOrderOption = 7;
                }
                else
                {
                    rushOrderOption = 0;
                }

            // Try block will try to get the data & send it.  Everything will fail if a field is null
            try
            {
                    string clientFirstName = CustomerNameInputBox.Text;
                    string clientLastName = LastNameInputBox.Text;
                    double width = double.Parse(DeskWidthInputBox.Text);
                    double depth = double.Parse(DeskDepthtInputBox.Text);
                    int drawers = int.Parse(NumberOfDrawersInputBox.Text);
                    string material = materialBox.Text;

                    DisplayQuoteInfo viewDisplayQuoteForm = new DisplayQuoteInfo(clientFirstName, clientLastName, width, depth, drawers, material, rushOrderOption);

                    // Now go back to the View Quote form
                    viewDisplayQuoteForm.Tag = this;
                    viewDisplayQuoteForm.Show(this);

                    // Now close this window
                    Hide();
                } catch (Exception)
            {
                MessageBox.Show("One or more of the fields is empty.  Please fill it in.");
            }
                // Now close this window
                Hide();
            }
        }

        // This validates the width input
        private void validateDeskWidthInput(object sender, CancelEventArgs e)
        {
            //  Get the width input.  If not a number, throw an exception
            try
            {
                double number = double.Parse(DeskWidthInputBox.Text);

                if (number < Desk.MINWIDTH || number > Desk.MAXWIDTH)
                {
                    DeskWidthInputBox.ForeColor = Color.Black;
                    DeskWidthInputBox.BackColor = Color.Red;
                    DeskWidthInputBox.Focus();
                    MessageBox.Show($"Min Width: {Desk.MINWIDTH}\"\nMax Width: {Desk.MAXWIDTH}\"");
                }
                else
                {
                    DeskWidthInputBox.ForeColor = Color.Black;
                    DeskWidthInputBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                DeskWidthInputBox.ForeColor = Color.Red;
                DeskWidthInputBox.Focus();
                MessageBox.Show("Please enter a number for the Width");
            }

        }

        // This validates the depth input
        private void validateDeskDepthInput(object sender, CancelEventArgs e)
        {
            try
            {
                double number = double.Parse(DeskDepthtInputBox.Text);

                if (number < Desk.MINDEPTH || number > Desk.MAXDEPTH)
                {
                    DeskDepthtInputBox.ForeColor = Color.Black;
                    DeskDepthtInputBox.BackColor = Color.Red;
                    DeskDepthtInputBox.Focus();
                    MessageBox.Show($"Min Width: {Desk.MINDEPTH}\"\nMax Width: {Desk.MAXDEPTH}\"");
                }
                else
                {
                    DeskDepthtInputBox.ForeColor = Color.Black;
                    DeskDepthtInputBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                DeskDepthtInputBox.ForeColor = Color.Red;
                DeskDepthtInputBox.Focus();
                MessageBox.Show("Please enter a number for the Depth");
            }
        }

        // Validates the number of drawers entered
        private void validateNumDrawersInput(object sender, CancelEventArgs e)
        {
            try
            {
                double number = double.Parse(NumberOfDrawersInputBox.Text);

                if (number < Desk.MINDRAWERS || number > Desk.MAXDRAWERS)
                {
                    NumberOfDrawersInputBox.ForeColor = Color.Black;
                    NumberOfDrawersInputBox.BackColor = Color.Red;
                    NumberOfDrawersInputBox.Focus();
                    MessageBox.Show($"Must enter a number between {Desk.MINDRAWERS} and {Desk.MAXDRAWERS}");
                }
                else
                {
                    NumberOfDrawersInputBox.ForeColor = Color.Black;
                    NumberOfDrawersInputBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number for the Number of Drawers");
                NumberOfDrawersInputBox.ForeColor = Color.Red;
                NumberOfDrawersInputBox.Focus();
            }
        }

        // Validates the surface material
        private void validateSurfaceMaterialInput(object sender, CancelEventArgs e)
        {
            try
            {
                string surfaceMaterial = materialBox.Text;

                Boolean isInputValid = isValidSurfaceMaterial(surfaceMaterial);


                // While the validation fails, change the text color
                if (!isInputValid)
                {
                    materialBox.ForeColor = Color.Black;
                    materialBox.BackColor = Color.Red;
                    materialBox.Focus();
                    MessageBox.Show("Please enter one of the following:\n Laminate\n Oak\n Rosewood\n Veneer\n Pine\n");
                }


                materialBox.ForeColor = Color.Black;
                materialBox.BackColor = Color.White;

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter one of the following: Laminate\n Oak\n Rosewood\n Veneer\n Pine\n");
                materialBox.ForeColor = Color.Red;
                materialBox.Focus();
            }
        }

        // Checks if the user input for Surface Material is valid.  If not, returns false
        private Boolean isValidSurfaceMaterial(string userInput)
        {
            Boolean valid = false;

            if (Enum.IsDefined(typeof(Desk.SurfaceMaterials), userInput))
            {
                valid = true;
            }
            

            return valid;
        }

        // Validates the first name input box contains valid characters
        private void CustomerNameInputBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(CustomerNameInputBox.Text, @"^[a-zA-Z \-\']+$"))
            {
                MessageBox.Show("First name cannot include special characters or numbers.");
                CustomerNameInputBox.Text = "";
            }
        }

        // Validates the last name input so that it contains valid characters
        private void LastNameInputBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(LastNameInputBox.Text, @"^[a-zA-Z \-\']+$"))
            {
                MessageBox.Show("Last name cannot include special characters or numbers.");
                LastNameInputBox.Text = "";
            }
        }

    }
}
