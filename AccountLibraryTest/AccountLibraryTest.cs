using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountsLibrary.ExtensionClass;

namespace AccountLibraryTest
{
    [TestClass]
    public class AccountLibraryTest
    {
        [TestMethod]
        public void should_return_true_when_the_two_dateTime_is_the_same_year_same_month()
        {
            DateTime dateTime = new DateTime(2019, 7, 3);
            DateTime targetDateTime = new DateTime(2019, 7, 3);
            bool result = dateTime.IsSameMonthOfSameYear(targetDateTime);
            Assert.IsTrue(result);
        }
    }
}
