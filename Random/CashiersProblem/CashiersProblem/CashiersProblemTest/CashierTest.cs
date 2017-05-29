using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.random.test
{
    [TestClass()]
    public class CashierTest
    {
        [TestMethod()]
        public void CalculateTest()
        {
            //arrange
            var list = new List<string>();
            list.Add("apple,banana,lemon");
            list.Add("banana,berry,lemon,orange");
            list.Add("banana,berry,lemon");

            //act
            Cashier.Calculate(list.ToArray());

            //assert

        }
    }
}