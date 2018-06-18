using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class TestPlusOperator
    {
        [TestMethod]
        public void PlusTwoLists()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list1 + list2;
            int expectedResult = 6;
            //Assert
            Assert.AreEqual(result[3], expectedResult);
        }
        [TestMethod]
        public void PlusTwoLists2()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list1 + list2 ;
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(result[1], expectedResult);
        }
        [TestMethod]
        public void PlusTwoLists3()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list2 + list1 ;
            int expectedResult = 2;
            //Assert
            Assert.AreEqual(result[3], expectedResult);
        }
        [TestMethod]
        public void PlusTwoLists4()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list2 + list1;
            int expectedResult = 6;
            //Assert
            Assert.AreEqual(result[1], expectedResult);
        }
        [TestMethod]
        public void PlusTwoUnequalLists()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list1 + list2;
            int expectedResult = 3;
            //Assert
            Assert.AreEqual(result[4], expectedResult);
        }
        [TestMethod]
        public void PlusTwoListsWithArrays()
        {
            //Arrange
            CustomList<string[]> list1 = new CustomList<string[]> (){ { "From", "Here" }, { "To", "There" } };
            CustomList<string[]> list2 = new CustomList<string[]> (){ { "In", "Out" }, { "Under", "Over" } };
            CustomList<string[]> result = new CustomList<string[]>();
            //Act
            result = list1 + list2;
            string[] expectedResult = { "In", "Out" };
            //Assert
            Assert.AreEqual(result[2]);
        }

    }
}
