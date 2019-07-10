using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsLibrary.ExtensionClass
{
    public static class Extension
    {
        public static bool IsSameMonthOfSameYear(this DateTime dateTime, DateTime targetDateTime)
        {
            return dateTime.Year == targetDateTime.Year && dateTime.Month == targetDateTime.Month;
        }
    }
}
