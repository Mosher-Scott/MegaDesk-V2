namespace MegaDesk_Mosher
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matRequired = new System.Windows.Forms.Label();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.LastNameInputBox = new System.Windows.Forms.TextBox();
            this.CustomerLastNameLabel = new System.Windows.Forms.Label();
            this.RushRadioSeven = new System.Windows.Forms.RadioButton();
            this.RushRadioFive = new System.Windows.Forms.RadioButton();
            this.RushRadioThree = new System.Windows.Forms.RadioButton();
            this.RushRadioNone = new System.Windows.Forms.RadioButton();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersInputBox = new System.Windows.Forms.TextBox();
            this.NumberofDrawersLabel = new System.Windows.Forms.Label();
            this.DeskDepthtInputBox = new System.Windows.Forms.TextBox();
            this.DeskDepthtInputLabel = new System.Windows.Forms.Label();
            this.DeskWidthInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameInputBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.GenerateQuoteButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(12, 352);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(111, 38);
            this.CloseFormButton.TabIndex = 12;
            this.CloseFormButton.Text = "&Return To Main";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.AddNewQuoteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.matRequired);
            this.groupBox1.Controls.Add(this.materialBox);
            this.groupBox1.Controls.Add(this.LastNameInputBox);
            this.groupBox1.Controls.Add(this.CustomerLastNameLabel);
            this.groupBox1.Controls.Add(this.RushRadioSeven);
            this.groupBox1.Controls.Add(this.RushRadioFive);
            this.groupBox1.Controls.Add(this.RushRadioThree);
            this.groupBox1.Controls.Add(this.RushRadioNone);
            this.groupBox1.Controls.Add(this.RushOrderLabel);
            this.groupBox1.Controls.Add(this.SurfaceMaterialLabel);
            this.groupBox1.Controls.Add(this.NumberOfDrawersInputBox);
            this.groupBox1.Controls.Add(this.NumberofDrawersLabel);
            this.groupBox1.Controls.Add(this.DeskDepthtInputBox);
            this.groupBox1.Controls.Add(this.DeskDepthtInputLabel);
            this.groupBox1.Controls.Add(this.DeskWidthInputBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustomerNameInputBox);
            this.groupBox1.Controls.Add(this.CustomerNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // matRequired
            // 
            this.matRequired.BackColor = System.Drawing.Color.LightSteelBlue;
            this.matRequired.Font = new System.Drawing.Font("Nirmala UI", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRequired.ForeColor = System.Drawing.Color.Crimson;
            this.matRequired.Location = new System.Drawing.Point(111, 187);
            this.matRequired.Name = "matRequired";
            this.matRequired.Size = new System.Drawing.Size(63, 18);
            this.matRequired.TabIndex = 35;
            this.matRequired.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // materialBox
            // 
            this.materialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialBox.Location = new System.Drawing.Point(178, 182);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 29);
            this.materialBox.TabIndex = 6;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.materialBox_SelectedIndexChanged);
            // 
            // LastNameInputBox
            // 
            this.LastNameInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameInputBox.Location = new System.Drawing.Point(178, 64);
            this.LastNameInputBox.Name = "LastNameInputBox";
            this.LastNameInputBox.Size = new System.Drawing.Size(102, 23);
            this.LastNameInputBox.TabIndex = 2;
            this.LastNameInputBox.TextChanged += new System.EventHandler(this.LastNameInputBox_TextChanged);
            // 
            // CustomerLastNameLabel
            // 
            this.CustomerLastNameLabel.AutoSize = true;
            this.CustomerLastNameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLastNameLabel.Location = new System.Drawing.Point(19, 72);
            this.CustomerLastNameLabel.Name = "CustomerLastNameLabel";
            this.CustomerLastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.CustomerLastNameLabel.TabIndex = 33;
            this.CustomerLastNameLabel.Text = "Last Name";
            // 
            // RushRadioSeven
            // 
            this.RushRadioSeven.AutoSize = true;
            this.RushRadioSeven.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.RushRadioSeven.Location = new System.Drawing.Point(178, 261);
            this.RushRadioSeven.Name = "RushRadioSeven";
            this.RushRadioSeven.Size = new System.Drawing.Size(59, 19);
            this.RushRadioSeven.TabIndex = 9;
            this.RushRadioSeven.TabStop = true;
            this.RushRadioSeven.Text = "7 Days";
            this.RushRadioSeven.UseVisualStyleBackColor = true;
            // 
            // RushRadioFive
            // 
            this.RushRadioFive.AutoSize = true;
            this.RushRadioFive.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.RushRadioFive.Location = new System.Drawing.Point(178, 241);
            this.RushRadioFive.Name = "RushRadioFive";
            this.RushRadioFive.Size = new System.Drawing.Size(59, 19);
            this.RushRadioFive.TabIndex = 8;
            this.RushRadioFive.TabStop = true;
            this.RushRadioFive.Text = "5 Days";
            this.RushRadioFive.UseVisualStyleBackColor = true;
            // 
            // RushRadioThree
            // 
            this.RushRadioThree.AutoSize = true;
            this.RushRadioThree.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.RushRadioThree.Location = new System.Drawing.Point(178, 220);
            this.RushRadioThree.Name = "RushRadioThree";
            this.RushRadioThree.Size = new System.Drawing.Size(59, 19);
            this.RushRadioThree.TabIndex = 7;
            this.RushRadioThree.TabStop = true;
            this.RushRadioThree.Text = "3 Days";
            this.RushRadioThree.UseVisualStyleBackColor = true;
            // 
            // RushRadioNone
            // 
            this.RushRadioNone.AutoSize = true;
            this.RushRadioNone.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.RushRadioNone.Location = new System.Drawing.Point(178, 280);
            this.RushRadioNone.Name = "RushRadioNone";
            this.RushRadioNone.Size = new System.Drawing.Size(105, 19);
            this.RushRadioNone.TabIndex = 10;
            this.RushRadioNone.TabStop = true;
            this.RushRadioNone.Text = "None (14 Days)";
            this.RushRadioNone.UseVisualStyleBackColor = true;
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(18, 214);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(111, 15);
            this.RushOrderLabel.TabIndex = 28;
            this.RushOrderLabel.Text = "Rush Order Options";
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(18, 185);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(92, 15);
            this.SurfaceMaterialLabel.TabIndex = 26;
            this.SurfaceMaterialLabel.Text = "Surface Material";
            // 
            // NumberOfDrawersInputBox
            // 
            this.NumberOfDrawersInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersInputBox.Location = new System.Drawing.Point(178, 151);
            this.NumberOfDrawersInputBox.Name = "NumberOfDrawersInputBox";
            this.NumberOfDrawersInputBox.Size = new System.Drawing.Size(54, 23);
            this.NumberOfDrawersInputBox.TabIndex = 5;
            this.NumberOfDrawersInputBox.MouseHover += new System.EventHandler(this.NumberOfDrawersInputBox_MouseHover);
            this.NumberOfDrawersInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateNumDrawersInput);
            // 
            // NumberofDrawersLabel
            // 
            this.NumberofDrawersLabel.AutoSize = true;
            this.NumberofDrawersLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofDrawersLabel.Location = new System.Drawing.Point(18, 159);
            this.NumberofDrawersLabel.Name = "NumberofDrawersLabel";
            this.NumberofDrawersLabel.Size = new System.Drawing.Size(112, 15);
            this.NumberofDrawersLabel.TabIndex = 25;
            this.NumberofDrawersLabel.Text = "Number Of Drawers";
            // 
            // DeskDepthtInputBox
            // 
            this.DeskDepthtInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthtInputBox.Location = new System.Drawing.Point(178, 122);
            this.DeskDepthtInputBox.Name = "DeskDepthtInputBox";
            this.DeskDepthtInputBox.Size = new System.Drawing.Size(54, 23);
            this.DeskDepthtInputBox.TabIndex = 4;
            this.DeskDepthtInputBox.MouseHover += new System.EventHandler(this.DesktopHeightInputBox_PopupMessage);
            this.DeskDepthtInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateDeskDepthInput);
            // 
            // DeskDepthtInputLabel
            // 
            this.DeskDepthtInputLabel.AutoSize = true;
            this.DeskDepthtInputLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthtInputLabel.Location = new System.Drawing.Point(18, 130);
            this.DeskDepthtInputLabel.Name = "DeskDepthtInputLabel";
            this.DeskDepthtInputLabel.Size = new System.Drawing.Size(67, 15);
            this.DeskDepthtInputLabel.TabIndex = 24;
            this.DeskDepthtInputLabel.Text = "Desk Depth";
            this.DeskDepthtInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeskWidthInputBox
            // 
            this.DeskWidthInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthInputBox.Location = new System.Drawing.Point(178, 93);
            this.DeskWidthInputBox.Name = "DeskWidthInputBox";
            this.DeskWidthInputBox.Size = new System.Drawing.Size(54, 23);
            this.DeskWidthInputBox.TabIndex = 3;
            this.DeskWidthInputBox.MouseHover += new System.EventHandler(this.textBox1_PopupMessage);
            this.DeskWidthInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateDeskWidthInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Desk Width";
            // 
            // CustomerNameInputBox
            // 
            this.CustomerNameInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameInputBox.Location = new System.Drawing.Point(178, 35);
            this.CustomerNameInputBox.Name = "CustomerNameInputBox";
            this.CustomerNameInputBox.Size = new System.Drawing.Size(102, 23);
            this.CustomerNameInputBox.TabIndex = 0;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AccessibleName = "";
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(18, 43);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(64, 15);
            this.CustomerNameLabel.TabIndex = 4;
            this.CustomerNameLabel.Text = "First Name";
            // 
            // GenerateQuoteButton
            // 
            this.GenerateQuoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerateQuoteButton.Location = new System.Drawing.Point(129, 352);
            this.GenerateQuoteButton.Name = "GenerateQuoteButton";
            this.GenerateQuoteButton.Size = new System.Drawing.Size(111, 38);
            this.GenerateQuoteButton.TabIndex = 11;
            this.GenerateQuoteButton.Text = "&Generate Quote";
            this.GenerateQuoteButton.UseVisualStyleBackColor = true;
            this.GenerateQuoteButton.Click += new System.EventHandler(this.GenerateQuote);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 398);
            this.Controls.Add(this.GenerateQuoteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseFormButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CustomerNameInputBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button GenerateQuoteButton;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.TextBox NumberOfDrawersInputBox;
        private System.Windows.Forms.Label NumberofDrawersLabel;
        private System.Windows.Forms.TextBox DeskDepthtInputBox;
        private System.Windows.Forms.Label DeskDepthtInputLabel;
        private System.Windows.Forms.TextBox DeskWidthInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RushRadioSeven;
        private System.Windows.Forms.RadioButton RushRadioFive;
        private System.Windows.Forms.RadioButton RushRadioThree;
        private System.Windows.Forms.RadioButton RushRadioNone;
        private System.Windows.Forms.TextBox LastNameInputBox;
        private System.Windows.Forms.Label CustomerLastNameLabel;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label matRequired;
    }
}