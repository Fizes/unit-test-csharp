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
    public class CalculatorTests
    {

        [TestMethod()]
        public void AddTest()
        {
            long temp = 999999999999999999;
            long result;
            Calculator calc = new Calculator();
            result = calc.Add(temp);
            Assert.AreEqual(temp, result);
        }
        
        [TestMethod()]
        public void SubstractTest1()
        {
            long temp = 999999999999999999;
            long result;
            Calculator calc = new Calculator();
            result = calc.Substract(temp);
            Assert.AreEqual(temp, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            long temp = 999999999999999999;
            long result;
            Calculator calc = new Calculator();
            result = calc.Multiply(temp);
            Assert.AreEqual(temp, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            long temp = 999999999999999999;
            long result;
            Calculator calc = new Calculator();
            result = calc.Divide(temp);
            Assert.AreEqual(temp, result);
        }

        [TestMethod()]
        public void DivideTest1()
        {
            long temp = 0;
            long result;
            Calculator calc = new Calculator();
            result = calc.Divide(temp);
            Assert.AreEqual(temp, result);
        }
    }
}