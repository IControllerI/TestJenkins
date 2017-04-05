using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjForJenk;

namespace TestMyCalc
{
    [TestClass]
    public class TestMyCalculator
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(2, calc.Add(1, 1));
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(2, calc.Sub(3, 1));
        }

        [TestMethod]
        public void TestMult()
        {
            Assert.AreEqual(6, calc.Mult(3, 2));
        }

        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(2, calc.Div(6, 3));
        }
    }
}
