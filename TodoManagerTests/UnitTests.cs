using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoManager;

namespace TodoManagerTests
{
    [TestClass]
    public class UnitTests
    { 
        [TestMethod]
        public void EmptyTask() // Saving empty task
        {
            const bool expected = false;
            Task task = new Task();
            var result = FileIO.SaveTask(task);
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DeleteNegativeTask() // Delete task with negative index
        {
            const bool expected = false;
            var result = FileIO.DeleteTask(-1000);

            Assert.AreEqual(expected, result);
        }

        //[TestMethod]
        //public void TestMethodTemplate()
        //{
        //    using var sw = new StringWriter();
        //    Console.SetOut(sw);
        //    TodoManager.FileIO.ContainsIllegalChars("\\This should return true");

        //    var result = sw.ToString().Trim();
        //    Assert.AreEqual(expected, result);
        //}
    }
}
