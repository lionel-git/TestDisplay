using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyData;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var df = new DataSummary();
           

            // throw new Exception("Test");

            Assert.AreNotEqual(df.FormatedDate, null);
        }
    }
}
