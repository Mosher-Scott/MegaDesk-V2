namespace MegaDesk_Mosher
{
    partial class SearchQuotes
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));

            this.CloseFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.tester3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskQuoteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deskQuoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 

            this.CloseFormButton.Location = new System.Drawing.Point(12, 371);

            this.CloseFormButton.Location = new System.Drawing.Point(12, 350);

            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(111, 35);
            this.CloseFormButton.TabIndex = 2;
            this.CloseFormButton.Text = "&Return To Main";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Quotes by Material:";
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
            this.materialBox.Location = new System.Drawing.Point(23, 25);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 21);
            this.materialBox.TabIndex = 11;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.materialBox_SelectedIndexChanged);
            // 
            // tester3
            // 
            this.tester3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tester3.Location = new System.Drawing.Point(21, 70);
            this.tester3.Name = "tester3";
            this.tester3.Size = new System.Drawing.Size(765, 298);
            this.tester3.TabIndex = 16;
            this.tester3.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientFirstNameDataGridViewTextBoxColumn,
            this.clientLastNameDataGridViewTextBoxColumn,
            this.submitDateDataGridViewTextBoxColumn,
            this.quoteTotalDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deskQuoteBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(51, 324);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 44);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientFirstNameDataGridViewTextBoxColumn
            // 
            this.clientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "clientFirstName";
            this.clientFirstNameDataGridViewTextBoxColumn.HeaderText = "clientFirstName";
            this.clientFirstNameDataGridViewTextBoxColumn.Name = "clientFirstNameDataGridViewTextBoxColumn";
            // 
            // clientLastNameDataGridViewTextBoxColumn
            // 
            this.clientLastNameDataGridViewTextBoxColumn.DataPropertyName = "clientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.HeaderText = "clientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.Name = "clientLastNameDataGridViewTextBoxColumn";
            // 
            // submitDateDataGridViewTextBoxColumn
            // 
            this.submitDateDataGridViewTextBoxColumn.DataPropertyName = "submitDate";
            this.submitDateDataGridViewTextBoxColumn.HeaderText = "submitDate";
            this.submitDateDataGridViewTextBoxColumn.Name = "submitDateDataGridViewTextBoxColumn";
            // 
            // quoteTotalDataGridViewTextBoxColumn
            // 
            this.quoteTotalDataGridViewTextBoxColumn.DataPropertyName = "quoteTotal";
            this.quoteTotalDataGridViewTextBoxColumn.HeaderText = "quoteTotal";
            this.quoteTotalDataGridViewTextBoxColumn.Name = "quoteTotalDataGridViewTextBoxColumn";
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // deskQuoteBindingSource2
            // 
            this.deskQuoteBindingSource2.DataSource = typeof(MegaDesk_Mosher.DeskQuote);
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk_Mosher.DeskQuote);
            // 
            // deskQuoteBindingSource1
            // 
            this.deskQuoteBindingSource1.DataSource = typeof(MegaDesk_Mosher.DeskQuote);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;

            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tester3);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.label1);

            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 399);

            this.Controls.Add(this.CloseFormButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).EndInit();


            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label tester3;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
    }
}