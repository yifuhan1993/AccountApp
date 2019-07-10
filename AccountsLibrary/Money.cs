using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsLibrary
{
    public class Money
    {
        public double value;
        public Currency currency;

        private double RMBAmount
        {
            get
            {
                return value * getExchangeRate(this.currency);
            }
        }

        private double getExchangeRate(Currency currency)
        {
            switch (currency)
            {
                case Currency.EUR:
                    return 7.76;
                case Currency.USD:
                    return 6.92;
                default:
                    return 1;
            }
        }

        public Money(double value) : this(value, Currency.RMB) { }

        public Money(double value, Currency currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public static Money operator +(Money value1, Money value2)
        {
            if (value1.currency != value2.currency)
            {
                throw new ArgumentException("Currency is not same.");
            }
            return new Money(value1.RMBAmount + value2.RMBAmount, value1.currency);
        }

        public static Money operator -(Money value1, Money value2)
        {
            if (value1.currency != value2.currency)
            {
                throw new ArgumentException("Currency is not same.");
            }
            return new Money(value1.RMBAmount - value2.RMBAmount, value1.currency);
        }

        public override string ToString()
        {
            if (currency != Currency.RMB)
                return $"{value} {currency} ({RMBAmount} RMB)";
            else
                return $"{value} {currency}";
        }
    }
}
