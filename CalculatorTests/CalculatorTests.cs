using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        private readonly int y = 10;
        private readonly int z = 0;
        private readonly int x = 20;

        [TestMethod()]
        public void SumTest()
        {
            Calculator calc = new Calculator();

            int a = calc.Add(x, y);

            Assert.AreEqual(30, a);
            Assert.AreEqual(30, calc.result);

        }

        [TestMethod()]
        public void DivideZeroTest()
        {
            Calculator calc = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(x, z));
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calc = new Calculator();

            int c = calc.Divide(x, y);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calc.result);
        }
    }
}