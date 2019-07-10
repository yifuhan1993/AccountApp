using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using AccountsLibrary.ExtensionClass;

namespace AccountsLibrary
{
    public class Accounts: IEnumerable
    {
        private List<AccountItem> accounts = new List<AccountItem>();

        public void AddItem(AccountItem item)
        {
            accounts.Add(item);
        }

        public AccountItem this[int i]
        {
            get => accounts[i];
            set => accounts[i] = value;
        }

        public void Remove(int i)
        {
            accounts.RemoveAt(i);
        }

        public Money MonthlyTotalRevenue(DateTime time)
        {
            Money revenue = new Money(0);
            foreach (AccountItem item in accounts)
            {
                if (item.occuredTime.Month == time.Month)
                {
                    if (item.occuredTime.Month == time.Month)
                    {
                        if (item.category == Category.Spending)
                            revenue -= item.amount;
                        if (item.category == Category.Income)
                            revenue += item.amount;
                    }
                }
            }
            return revenue;
        }

        public Money MonthlyTotalExpenditure(DateTime time)
        {
            return Calculate(accountItem => time.IsSameMonthOfSameYear(accountItem.occuredTime) && accountItem.IsSpending());
        }

        public Money MonthlyTotalIncome(DateTime time)
        {
            return Calculate(accountItem => time.IsSameMonthOfSameYear(accountItem.occuredTime) && accountItem.IsIncome());
        }

        public Money Calculate(Match match)
        {
            Money income = new Money(0);
            foreach (AccountItem item in accounts)
            {
                if (match(item))
                {
                    income += item.amount;
                }
            }
            return income;
        }

        public IEnumerable<AccountItem> MonthlyItems(DateTime time)
        {
            foreach (AccountItem item in accounts)
            {
                if (item.occuredTime.Month == time.Month)
                {
                    {
                        yield return item;
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)accounts).GetEnumerator();
        }
    }

    public delegate bool Match(AccountItem item);
}
