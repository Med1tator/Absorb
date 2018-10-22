using Microsoft.VisualStudio.TestTools.UnitTesting;
using Absorb.UnitTest.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absorb.UnitTest.Sample.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void GetSumTest()
        {
            //单元测试：特定的输入能否得到预期的输出
            Assert.IsTrue(new Calculator().GetSum(10) == 55, "Not equals 55");
        }

        [TestMethod()]
        public void GetSumOfTwoGetSumOfTwoTest()
        {
            Assert.AreEqual(new Calculator().GetSumOfTwo(1, 1), 2);
        }
    }
}