﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Mosher
{
    //Testing Push
    //Trevor Testing Push
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            // Allows you to shrink code blocks
            #region

            #endregion

            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        // Hiding all the methods that are empty
        #region

        private void button1_Click(object sender, EventArgs e)
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

        #endregion

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

        private void GenerateQuote(object sender, EventArgs e)
        {


            //Check if the material drop down has a value -TS
            if (materialBox.Text == "")

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

            //set Rush Day to Value
            if (RushRadioNone.Checked)

            {
                // Validation message. 
                errorProvider1.SetError(materialBox, "Material Selection Required.");
                matRequired.Text = " -Required";

            }

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
                //Old Surface Material Textbox:
                //string material = SurfaceMaterialInputBox.Text;
                //int rushOrderOption = int.Parse(RushOrderInputBox.Text);

                // Scott - I don't think we need to create a Desk object here.  With the way I've currently written the code, I create a desk object on the DisplayQuotes form
                // Desk myDesk = new Desk(width, depth, drawers, material, rushOrderOption);

                DisplayQuoteInfo viewDisplayQuoteForm = new DisplayQuoteInfo(clientFirstName, clientLastName, width, depth, drawers, material, rushOrderOption);

                // Now go back to the View Quote form
                viewDisplayQuoteForm.Tag = this;
                viewDisplayQuoteForm.Show(this);

                string material = SurfaceMaterialInputBox.Text;

                DisplayQuoteInfo viewDisplayQuoteForm = new DisplayQuoteInfo(clientFirstName, clientLastName, width, depth, drawers, material, rushOrderOption);

                //Lanch Add Quote Form
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



        private void matValue_Click(object sender, EventArgs e)
        {

        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        //private void validateRushoptionInput(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        int rushOption = int.Parse(RushOrderInputBox.Text);


        //        // While the validation fails, change the text color
        //        if (rushOption == 3 || rushOption == 5 || rushOption == 7 || rushOption == 14)
        //        {

        //        } else
        //        {
        //            RushOrderInputBox.ForeColor = Color.Black;
        //            RushOrderInputBox.BackColor = Color.Red;
        //            RushOrderInputBox.Focus();
        //            MessageBox.Show($"Valid days are 3, 5, 7, or 14.  You entered {rushOption}");
        //        }


        //        RushOrderInputBox.ForeColor = Color.Black;
        //        RushOrderInputBox.BackColor = Color.White;

        //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show("Please enter a number for the Number of Drawers");
        //        RushOrderInputBox.ForeColor = Color.Red;
        //        RushOrderInputBox.Focus();
        //    }
        //}

        private void CustomerNameInputBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(CustomerNameInputBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("First name cannot include special characters or numbers.");
                CustomerNameInputBox.Text = "";
            }
        }


        private void LastNameInputBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(LastNameInputBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Last name cannot include special characters or numbers.");
                LastNameInputBox.Text = "";
            }
        }
    }
}
