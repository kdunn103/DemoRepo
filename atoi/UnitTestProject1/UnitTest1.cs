using System;
using StringToInt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyAtoi_ShouldReturn850_WhenGiven850()
        {
            //Arrange
            string testString = "850";

            int returnValue =  Program.MyAtoi(testString);

            Assert.AreEqual(returnValue, 850);
        }
    }
}
