using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountsLibrary;
using AccountsLibrary.ExtensionClass;

namespace AccountApp
{
    public partial class Form1 : Form
    {
        private Accounts account;

        public Form1()
        {
            InitializeComponent();
            account = DataInputAccess.ReadAccountItems();
            foreach (AccountItem item in account)
                All.Items.Add(item);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            RevenueTextBox.Text = account.MonthlyTotalRevenue(dateTimePicker1.Value).ToString();
            IncomeTextBox.Text = account.MonthlyTotalExpenditure(dateTimePicker1.Value).ToString();
            ExpendTextBox.Text = account.MonthlyTotalIncome(dateTimePicker1.Value).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            Category category = InputUtility.GetCategory(ComboBoxCategory.Text);
            double amount = Convert.ToDouble(TextBoxAmount.Text);
            Currency currency = InputUtility.GetCurrency(ComboBoxCurrency.Text);
            DateTime occuredTime = OccuredTimePicker.Value;
            string note = TextBoxNote.Text;
            if (note == null)
                note = "None";
            string content = TextBoxContent.Text;
            if (content == null)
                content = "None";

            AccountItem item = new AccountItem(name, category, amount, currency, occuredTime, content, note);
            account.AddItem(item);
            DataInputAccess.WriteAccountItems(account);
            All.Items.Add(item);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int index = All.SelectedIndex;
            account.Remove(index);
            All.Items.RemoveAt(index);
            DataInputAccess.WriteAccountItems(account);
        }
    }
}
