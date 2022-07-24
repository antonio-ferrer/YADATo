using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace YADAToUT
{
    [TestClass]
    public class MainUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Regex.IsMatch("Say my name", "name", RegexOptions.IgnoreCase));
        }
    }
}
