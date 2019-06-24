using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShould_Add()
        {
            var calc = new Calculator.Calculator();

            var result=calc.Add(3);

            Assert.AreEqual(3,result);
        }

        [TestMethod]
        public void TestShould_Substract()
        {
            var calc = new Calculator.Calculator();

            var result = calc.Substract(3);

            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void TestShould_Multiply()
        {
            var calc = new Calculator.Calculator();

            var result = calc.Multiply(3);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestShouldnt_DivideZero()
        {
            var calc = new Calculator.Calculator();

            Assert.ThrowsException<ArgumentException>(()=> calc.Divide(0));
        }
        [TestMethod]
        public void TestShould_Divide()
        {
            var calc = new Calculator.Calculator();
            calc.Add(7);

            Assert.AreEqual(1,calc.Divide(7));
        }
    }
}
