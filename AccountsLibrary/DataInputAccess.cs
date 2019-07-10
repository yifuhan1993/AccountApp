using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace AccountsLibrary
{
    public class DataInputAccess
    {
        public static void WriteAccountItems(Accounts account)
        {
            string filePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "AccountItems.txt");

            using (StreamWriter streamwriter = new StreamWriter(filePath))
            {
                foreach (AccountItem item in account)
                {
                    streamwriter.WriteLine(item.ToItemString());
                }
            }
        }

        public static Accounts ReadAccountItems()
        {
            Accounts account = new Accounts();
            string filePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "AccountItems.txt");

            if (!File.Exists(filePath))
                return account;

            using (StreamReader streamwriter = new StreamReader(filePath))
            {
                string[] oneLine = Regex.Split(streamwriter.ReadToEnd(), @"\r\n");

                for (int i = 0; i < oneLine.Length - 1; i++)
                {
                    AccountItem item = ParseItem(oneLine[i]);
                    account.AddItem(item);
                }
            }
            return account;
        }

        private static AccountItem ParseItem(string oneSingleLine)
        {
            string[] elements = Regex.Split(oneSingleLine.Trim(), @"\s+");
            string divideSpace = "|";
            int property = 0;

            string name = null;
            string categoryString = null;
            string amountString = null;
            string currencyString = null;
            string content = null;
            string note = null;
            string yearString = null;
            string monthString = null;
            string dayString = null;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == divideSpace)
                {
                    property++;
                    i++;
                }

                if (property == 0)
                    name += elements[i];
                if (property == 1)
                    categoryString += elements[i];
                if (property == 2)
                    amountString += elements[i];
                if (property == 3)
                    currencyString += elements[i];
                if (property == 4)
                    yearString += elements[i];
                if (property == 5)
                    monthString += elements[i];
                if (property == 6)
                    dayString += elements[i];
                if (property == 7)
                    note += elements[i];
                if (property == 8)
                    content += elements[i];
            }

            Category category = InputUtility.GetCategory(categoryString);
            double amount = Convert.ToDouble(amountString);
            Currency currency = InputUtility.GetCurrency(currencyString);

            int year = Convert.ToInt32(yearString);
            int month = Convert.ToInt32(monthString);
            int day = Convert.ToInt32(dayString);
            DateTime occuredTime = new DateTime(year, month, day);

            return new AccountItem(name, category, amount, currency, occuredTime, note, content);
        }
    }

    public static class InputUtility
    {
        public static Category GetCategory(string category)
        {
            if (category.ToUpper() == "INCOME")
                return Category.Income;
            return Category.Spending;
        }

        public static Currency GetCurrency(string currency)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return Currency.USD;
                case "EUR":
                    return Currency.EUR;
                default:
                    return Currency.RMB;
            }
        }
    }
}
