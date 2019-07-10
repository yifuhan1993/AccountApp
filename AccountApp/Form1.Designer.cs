namespace AccountApp
{
    partial class Form1
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
            this.Calculate = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.TextBoxNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.ComboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.OccuredTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Wallet = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ExpendTextBox = new System.Windows.Forms.TextBox();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.RevenueTextBox = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.Income = new System.Windows.Forms.Label();
            this.Expend = new System.Windows.Forms.Label();
            this.Revenue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Wallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(41, 218);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(116, 21);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(89, 18);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 2;
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.Location = new System.Drawing.Point(89, 153);
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.Size = new System.Drawing.Size(100, 20);
            this.TextBoxContent.TabIndex = 3;
            // 
            // TextBoxNote
            // 
            this.TextBoxNote.Location = new System.Drawing.Point(89, 176);
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNote.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "Income",
            "Spending"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(89, 45);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxCategory.TabIndex = 7;
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Location = new System.Drawing.Point(89, 73);
            this.TextBoxAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAmount.TabIndex = 8;
            // 
            // ComboBoxCurrency
            // 
            this.ComboBoxCurrency.FormattingEnabled = true;
            this.ComboBoxCurrency.Items.AddRange(new object[] {
            "RMB",
            "USD",
            "EUR"});
            this.ComboBoxCurrency.Location = new System.Drawing.Point(89, 99);
            this.ComboBoxCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxCurrency.Name = "ComboBoxCurrency";
            this.ComboBoxCurrency.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxCurrency.TabIndex = 9;
            // 
            // OccuredTimePicker
            // 
            this.OccuredTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OccuredTimePicker.Location = new System.Drawing.Point(89, 127);
            this.OccuredTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OccuredTimePicker.Name = "OccuredTimePicker";
            this.OccuredTimePicker.Size = new System.Drawing.Size(100, 20);
            this.OccuredTimePicker.TabIndex = 10;
            this.OccuredTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(18, 75);
            this.Amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 11;
            this.Amount.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Content";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Note";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.Calculate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxNote);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextBoxContent);
            this.groupBox1.Controls.Add(this.ComboBoxCategory);
            this.groupBox1.Controls.Add(this.OccuredTimePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboBoxCurrency);
            this.groupBox1.Controls.Add(this.TextBoxAmount);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Location = new System.Drawing.Point(29, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(202, 253);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(441, 109);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(64, 21);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // All
            // 
            this.All.FormattingEnabled = true;
            this.All.Location = new System.Drawing.Point(517, 42);
            this.All.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(405, 251);
            this.All.TabIndex = 18;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(441, 142);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(64, 24);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Wallet
            // 
            this.Wallet.Controls.Add(this.dateTimePicker1);
            this.Wallet.Controls.Add(this.ExpendTextBox);
            this.Wallet.Controls.Add(this.IncomeTextBox);
            this.Wallet.Controls.Add(this.RevenueTextBox);
            this.Wallet.Controls.Add(this.Date);
            this.Wallet.Controls.Add(this.Income);
            this.Wallet.Controls.Add(this.Expend);
            this.Wallet.Controls.Add(this.Revenue);
            this.Wallet.Location = new System.Drawing.Point(247, 42);
            this.Wallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Wallet.Name = "Wallet";
            this.Wallet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Wallet.Size = new System.Drawing.Size(190, 253);
            this.Wallet.TabIndex = 20;
            this.Wallet.TabStop = false;
            this.Wallet.Text = "Wallet";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 158);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // ExpendTextBox
            // 
            this.ExpendTextBox.Location = new System.Drawing.Point(89, 114);
            this.ExpendTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExpendTextBox.Name = "ExpendTextBox";
            this.ExpendTextBox.Size = new System.Drawing.Size(85, 20);
            this.ExpendTextBox.TabIndex = 6;
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.Location = new System.Drawing.Point(88, 74);
            this.IncomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.Size = new System.Drawing.Size(86, 20);
            this.IncomeTextBox.TabIndex = 5;
            // 
            // RevenueTextBox
            // 
            this.RevenueTextBox.Location = new System.Drawing.Point(88, 36);
            this.RevenueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RevenueTextBox.Name = "RevenueTextBox";
            this.RevenueTextBox.Size = new System.Drawing.Size(86, 20);
            this.RevenueTextBox.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(17, 157);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date";
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Location = new System.Drawing.Point(17, 76);
            this.Income.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(42, 13);
            this.Income.TabIndex = 2;
            this.Income.Text = "Income";
            // 
            // Expend
            // 
            this.Expend.AutoSize = true;
            this.Expend.Location = new System.Drawing.Point(17, 116);
            this.Expend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Expend.Name = "Expend";
            this.Expend.Size = new System.Drawing.Size(43, 13);
            this.Expend.TabIndex = 1;
            this.Expend.Text = "Expend";
            // 
            // Revenue
            // 
            this.Revenue.AutoSize = true;
            this.Revenue.Location = new System.Drawing.Point(17, 36);
            this.Revenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Revenue.Name = "Revenue";
            this.Revenue.Size = new System.Drawing.Size(51, 13);
            this.Revenue.TabIndex = 0;
            this.Revenue.Text = "Revenue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 330);
            this.Controls.Add(this.Wallet);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.All);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Wallet.ResumeLayout(false);
            this.Wallet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxContent;
        private System.Windows.Forms.TextBox TextBoxNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.ComboBox ComboBoxCurrency;
        private System.Windows.Forms.DateTimePicker OccuredTimePicker;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox All;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox Wallet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ExpendTextBox;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.TextBox RevenueTextBox;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Income;
        private System.Windows.Forms.Label Expend;
        private System.Windows.Forms.Label Revenue;
    }
}

