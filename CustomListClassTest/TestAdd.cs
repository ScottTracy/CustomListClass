using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;




namespace CustomListTest
{
    [TestClass]
    public class TestAdd
    {
        [TestMethod]
        public void AddValueToFirstIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value = 5;
            //Act
            list.Add(value);
            //Assert
            Assert.AreEqual(list[0], value);
        }
        [TestMethod]
        public void AddValueToSecondIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstValue = 5;
            int secondValue = 7;
            //Act
            list.Add(firstValue);
            list.Add(secondValue);
            //Assert

            Assert.AreEqual(list[0], firstValue);
        }
        [TestMethod]
        public void AddValueToSecondIndex2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstValue = 5;
            int secondValue = 7;
            //Act
            list.Add(firstValue);
            list.Add(secondValue);
            //Assert
            Assert.AreEqual(list[1], secondValue);
        }

        [TestMethod]
        public void AddString()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value = 5;
            //Act
            list.Add(value);
            //Assert
            Assert.AreEqual(list[0], value);
        }
        [TestMethod]
        public void AddArray()
        {
            //Arrange
            CustomList<int[]> list = new CustomList<int[]>();
            int[] array1 = { 1, 2 };
            int[] array2 = { 3, 4 };
            //Act
            list.Add(array1);
            list.Add(array2);
            //Assert
            Assert.AreEqual(list[0], array1);

        }
        [TestMethod]
        public void AddArrayCheck2()
        {
            //Arrange
            CustomList<int[]> list = new CustomList<int[]>();
            int[] array1 = { 1, 2 };
            int[] array2 = { 3, 4 };
            //Act
            list.Add(array1);
            list.Add(array2);
            //Assert
            Assert.AreEqual(list[1], array2);

        }
        [TestMethod]
        public void AddGetCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int value = 5;
            //Act
            list.Add(value);
            int expectedresult = 5;
            //Assert
            Assert.AreEqual(list.Count, expectedresult);


            
        }

    }
}
