using System;
using _3_lab_func;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = -10;
            double a = -2;
            double ExpectedValue = -148.42;

            Assert.AreEqual(ExpectedValue, Math.Round(FuncClass.GetPointY(a, x), 2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = -9;
            double a = -2;
            double ExpectedValue = -90.03;

            Assert.AreEqual(ExpectedValue, Math.Round(FuncClass.GetPointY(a, x), 2));
        }
    }
}
