using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListClassTest
{
    [TestClass]
    public class TestToString
    {
        [TestMethod]
        public void TestToStringInt()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            string result = list.ToString();
            string expectedResult = "1234";
            //Assert
            Assert.AreEqual(expectedResult, result);


        }
        [TestMethod]
        public void TestToStringStrings()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "F","O","O" };
            //Act
            string result = list.ToString();
            string expectedResult = "FOO";
            //Assert
            Assert.AreEqual(expectedResult, result);
        }


    }
}
