using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TodoManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TodoManager.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
