using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassTest
{
    [TestClass]
    public class TestPlusOperator
    {
        [TestMethod]
        public void PlusTwoLists()
        {
            //Arrange
            List<int> list1 = new List<int>() { 1, 2, };
            List<int> list2 = new List<int>() { 5, 6, };
            List<int> result = new List<int>();
            //Act
            list1 + list2 = result;
            int expectedResult = 6;
            //Assert
            Assert.AreEqual(result[3], expectedResult);
        }
        [TestMethod]
        public void PlusTwoLists2()
        {
            //Arrange
            List<int> list1 = new List<int>() { 1, 2, };
            List<int> list2 = new List<int>() { 5, 6, };
            List<int> result = new List<int>();
            //Act
            list1 + list2 = result;
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(result[1], expectedResult);
        }
        [TestMethod]
        public void PlusTwoLists2()
        {
            //Arrange
            List<int> list1 = new List<int>() { 1, 2, };
            List<int> list2 = new List<int>() { 5, 6, };
            List<int> result = new List<int>();
            //Act
            list2 + list1 = result;
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(result[3], expectedResult);
        }
        [TestMethod]
        public void PlusTwoLists2()
        {
            //Arrange
            List<int> list1 = new List<int>() { 1, 2, };
            List<int> list2 = new List<int>() { 5, 6, };
            List<int> result = new List<int>();
            //Act
            list2 + list1 = result;
            int expectedResult = 6;
            //Assert
            Assert.AreEqual(result[1], expectedResult);
        }
        [TestMethod]
        public void PlusTwoLists2()
        {
            //Arrange
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = new List<int>() { 5, 6, };
            List<int> result = new List<int>();
            //Act
            list1 + list2 = result;
            int expectedResult = 3;
            //Assert
            Assert.AreEqual(result[4], expectedResult);
        }
    }
}
