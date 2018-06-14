using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CustomListClassTest
{
    [TestClass]
    public class TestAdd
    {
        [TestMethod]
        public void  AddValueToFirstIndex()
        {
            //Arrange
            List<int> list = new List<int>();
            int value = 5;
            //Act
            list.add(value);
            //Assert
            Assert.AreEqual(list[0], value);
        }
        [TestMethod]
        public void AddValueToSecondIndex()
        {
            //Arrange
            List<int> list = new List<int>();
            int firstValue = 5;
            int secondValue = 7;
            //Act
            list.add(firstValue);
            list.add(secondValue);
            //Assert
           
            Assert.AreEqual(list[0], firstValue);
        }
        [TestMethod]
        public void AddValueToSecondIndex2()
        {
            //Arrange
            List<int> list = new List<int>();
            int firstValue = 5;
            int secondValue = 7;
            //Act
            list.add(firstValue);
            list.add(secondValue);
            //Assert
            Assert.AreEqual(list[1], secondValue);
           
        [TestMethod]
        public void AddString()
        {
            //Arrange
            List<int> list = new List<int>();
            int value = 5;
            //Act
            list.add(value);
            //Assert
            Assert.AreEqual(list[0], value);
        }
        [TestMethod]
        public void AddArray()
        {
            //Arrange
            List<int[]> list = new List<int[]>;
            int[] array1 = { 1, 2 };
            int[] array2 = { 3, 4 };
            //Act
            list.add(array1);
            list.add(array2);
            //Assert
            Assert.AreEqual(list[0], array1);

        }
        [TestMethod]
        public void AddArrayCheck2()
        {
            //Arrange
            List<int[]> list = new List<int[]>;
            int[] array1 = { 1, 2 };
            int[] array2 = { 3, 4 };
            //Act
            list.add(array1);
            list.add(array2);
            //Assert
            Assert.AreEqual(list[1], array2);

        }

    }
}
