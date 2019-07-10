using System;

namespace AccountsLibrary
{
    public class AccountItem
    {
        protected string Name { get; set; }
        public Category category;
        public Money amount;
        public DateTime occuredTime;
        protected string Content { get; set; }
        protected string Note { get; set; }

        public AccountItem(string name, Category category, double amount, DateTime occuredTime, string content, string note)
        {
            if (amount == 0)
                throw new ArgumentException("The amount should not be zero");

            this.Name = name;
            this.category = category;
            this.amount = new Money(amount);
            this.occuredTime = occuredTime;
            this.Content = content;
            this.Note = note;
        }

        public AccountItem(string name, Category category, double amount, Currency currency, DateTime occuredTime, string content, string note)
        {
            if (amount == 0)
                throw new ArgumentException("The amount should not be zero");

            this.Name = name;
            this.category = category;
            this.amount = new Money(amount, currency);
            this.occuredTime = occuredTime;
            this.Content = content;
            this.Note = note;
        }

        public bool IsIncome()
        {
            return this.category == Category.Income;
        }

        public bool IsSpending()
        {
            return this.category == Category.Spending;
        }

        DateTime time = new DateTime();

        public AccountItem(string name, Category category, double amount) : this(name, category, amount, Currency.RMB, DateTime.Now, "None", "None") { }

        public AccountItem(string name, Category category, double amount, Currency currency) : this(name, category, amount, currency, DateTime.Now, "None", "None") { }

        public AccountItem(string name, Category category, double amount, DateTime occuredTime) : this(name, category, amount, occuredTime, "None", "None") { }

        public AccountItem(string name, Category category, double amount, DateTime occuredTime, string content) : this(name, category, amount, occuredTime, content, "None") { }

        public override string ToString()
        {
            return $"{Name.ToUpper()} Category:{category} Amount:{amount.value} {amount.currency} Time:{occuredTime.ToString("MMMM dd,yy")} Content:{Content} Note:{Note}";
        }

        public string ToItemString()
        {
            return $"{Name} | {category.ToString()} | {amount.value} | {amount.currency} | {occuredTime.Year} | {occuredTime.Month} | {occuredTime.Day} | {Content} | {Note} |";
        }
    }
}
