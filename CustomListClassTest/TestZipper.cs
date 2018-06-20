using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListClassTest
{
    [TestClass]
    public class TestZipper
    {
        [TestMethod]
        public void TestZipCount()
        {
            //Assert
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, 7, 8 };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list1.Zip(list2, (a, b) => (a + b));
            int expectedResult = 8;
            //Assert
            Assert.AreEqual(expectedResult, result.Count);


        }
        [TestMethod]
        public void TestZipPosition()
        {
            //Assert
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, 7, 8 };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list1.Zip(list2, (a, b) => (a + b));
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(expectedResult, result[2]);


        }
    }
}
