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
            Assert.IsTrue(new Calculator().GetSum(10) == 55,"Not equals 55");
        }

        [TestMethod()]
        public void GetSumTest2()
        {
            //单元测试：特定的输入能否得到预期的输出
            //Assert.AreEqual(55, new Calculator().GetSum(10));

            //string s1 = "Hello ", s2 = "World!";
            //string str1 = "Hello World!"; string str2 = s1 + s2;
            //Assert.AreSame(str1, str2);

            //string str3=null;
            //Assert.IsNull(str3);
            //Assert.IsNotNull(new object());
        }
    }
}