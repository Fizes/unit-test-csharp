using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTestsCalculator
    {


        [TestMethod()]
        public void AddTestAddPositive()
        {
            Calculator calc = new Calculator();

            long expected = 4;
            long actual;

            calc.Add(2);
            actual = calc.Add(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstractTestSubstractPositive()
        {
            Calculator calc = new Calculator();

            long expected = 0;
            long actual;

            calc.Substract(4);
            actual = calc.Substract(-4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTestMultiplyPositive()
        {
            Calculator calc = new Calculator();

            long expected = 4;
            long actual;

            calc.Add(2);
            actual = calc.Multiply(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTestDividePositive()
        {
            Calculator calc = new Calculator();
            long expected = 2;
            long actual;

            calc.Add(4);
            actual = calc.Divide(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTestAddNegative()
        {
            Calculator calc = new Calculator();

            long expected = 2;
            long actual;

            calc.Add(2);
            actual = calc.Add(2);

            Assert.AreNotEqual(expected, actual);
        }
    }
}