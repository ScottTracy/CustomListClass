using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class TestRemove
    {
        [TestMethod]
        public void RemoveIntWithInt()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            list.Remove(1);
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(list[0], expectedResult);

        }
        [TestMethod]
        public void RemoveIntWithInt2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            list.Remove(1);
            int expectedResult = 3;
            //Assert
            Assert.AreEqual(list[1], expectedResult);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveIntWithException()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            list.Remove(1);
            Console.WriteLine(list[3]);
        }
        [TestMethod]
        public void RemoveIntWithVar()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int value = 2;
            //Act
            list.Remove(value);
            int expectedResult = 3;
            //Assert
            Assert.AreEqual(list[1], expectedResult);

        }
        [TestMethod]
        public void RemoveIntWithIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            list.Remove(list[0]);
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(list[0], expectedResult);
        }
        [TestMethod]
        public void RemoveStringWithString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "From", "Here", "To", "There" };
            //Act
            list.Remove("From");
            string expectedResult = "Here";
            //Assert
            Assert.AreEqual(list[0], expectedResult);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveStringWithException()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "From", "Here", "To", "There" };
            //Act
            list.Remove("Here");
            Console.WriteLine(list[3]);
        }
        [TestMethod]
        public void RemoveStringsWithArray()
        {
            //Arrange
            CustomList<string[]> list = new CustomList<string[]>() { { "From", "Here" },{ "To", "There" } };

            string[] array = { "From" , "Here" };
            //Act
            list.Remove(array);
            string[] expectedResult = { "To", "there" };
            //Assert
            Assert.AreEqual(expectedResult, list[0]);
        }
        [TestMethod]
        public void RemoveIntWithInt3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            list.Remove(1);
            int expectedResult = 3;
            //Assert
            Assert.AreEqual(list.Count, expectedResult);

        }





    }
}
