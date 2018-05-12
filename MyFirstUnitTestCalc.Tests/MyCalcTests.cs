using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstUnitTestCalc.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrangr
            int a = 10;
            int b = 20;
            int expected = 30;

            //act

            MyCalc c = new MyCalc();
            int actual = c.Sum(a, b);

            //assert

            Assert.AreEqual(expected, actual);

        }
    }
}
