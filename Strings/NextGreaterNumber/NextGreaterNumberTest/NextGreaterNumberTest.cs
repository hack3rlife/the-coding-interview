﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace NextGreaterNumberTest
{
    [TestClass]
    public class NextGreaterNumberTest
    {
        [TestMethod]
        public void FindNextTest()
        {
            //arrange
            string number = "534976";
            
            //act
            string actual = NextGreaterNumber.Next(number);
            string expected = "536479";
            
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
