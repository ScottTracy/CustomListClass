using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class TestMinusOperator
    {
        [TestMethod]
        public void TestListInt()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> list2 = new CustomList<int>() { 3, 4, 5 };
            CustomList<int> result = new CustomList<int>();
            //Act
            int expectedResult = 6;
            result = list1 - list2;
            //Assert
            Assert.AreEqual(expectedResult, result[2]);
        }
        [TestMethod]
        public void TestListString()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>() { "a", "b", "c", "d" };
            CustomList<string> list2 = new CustomList<string>() { "b", "d" };
            CustomList<string> result = new CustomList<string>();
            //Act
            result = list1 - list2;
            string expectedResult = "c";
            //Assert
            Assert.AreEqual(result[1], expectedResult);

        }
        [TestMethod]
        public void TestNonRemoval()
        {   //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> list2 = new CustomList<int>() { 6, 7 };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list1 - list2;
            int expectedResult = 5;
            //Assert
            Assert.AreEqual(expectedResult, result.Count);
        }
        [TestMethod]
        public void TestListStringCount()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>() { "a", "b", "c", "d" };
            CustomList<string> list2 = new CustomList<string>() { "b", "d" };
            CustomList<string> result = new CustomList<string>();
            //Act
            result = list1 - list2;
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(result.Count, expectedResult);

        }
    }
}
