using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CustomList;


namespace CustomList_Test
{
    [TestClass]
    public class RakList_Test
    {
        [TestMethod]
        public void Add_AddItemToEmptyList()
        {
            //Arrange
            RakList<int> list = new RakList<int>();
            int expectedResult = 5;

            //Act
            list.Add(5);
            int actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_AddItemToOccupupiedList()
        {
            //Arrange
            RakList<string> list = new RakList<string>() { "alpha", "bravo", "charlie", "delta" };

            string input = "echo";

            //Act
            list.Add(input);
            string expectedResult = input;

            //Assert
            Assert.AreEqual(input, list[4]);
        }

        [TestMethod]

        public void Add_AddItemToFullList_AddToNewIndex()
        {
            //Arrange
            RakList<int> list = new RakList<int>() { 0, 1, 2, 3, 4 };
            int newInput = 5;
            int actualResult = newInput;
            

            //Act
            list.Add(newInput);
         
            //Assert
            Assert.AreEqual(newInput, list[5]); //input will be found at newList[0];
        }
        [TestMethod]

        public void Add_AddItemToFullList_DoubleCount()
        {
            //Arrange
            RakList<int> list = new RakList<int>() { 0, 1, 2, 3, 4 };
            int newInput = 5;

            //Act
            list.Add(newInput);

            //Assert
            Assert.AreEqual(list.Count, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_ItemFromEmptyList()
        {
            //Arrange
            RakList<string> list = new RakList<string>();

            //Act
            list.Remove("value");
            string actualValue = list[0];

            //Assert

        }

        [TestMethod]
        public void Remove_MoreThanOneItemExists_ChecksCount()
        {
            //Arrange
            RakList<string> list = new RakList<string>() { "alpha", "bravo", "charlie", "delta", "echo", "alpha" };
            string expectedValue = "alpha";


            //Act
            list.Remove("alpha");
            string actualValue = list[4];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            int newCapacity = list.Count - 1;

            //test that count goes down
            Assert.AreEqual(newCapacity, list.Count);
        }

        [TestMethod]
        public void Remove_NoItemExists()
        {
            //Arrange
            RakList<int> list = new RakList<int>() { 0, 1, 2, 3, 4 };
            int input = 5;

            //Act
            list.Remove(input);
            int actualValue = list.Count;
            int expectedValue = 5;

            //Assert
            //remove something that doesn't exist count remains same
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Remove_NoItemExists_IndexRemainsSame()
        {
            //Arrange
            RakList<int> list = new RakList<int> { 0, 1, 2, 3, 4 };
            int input = 5;

            //Act
            list.Remove(input);

            //Asser2
            Assert.AreEqual(0, list[3]);
        }

        [TestMethod]
        public void Remove_NoItemExists_ReturnFalse()
        {
            //Arrange
            RakList<int> list = new RakList<int> { 0, 1, 2, 3, 4 };
            int input = 5;
            bool foundItem;

            //Act
            list.Remove(input);
            foundItem = false;

            //Assert
            Assert.IsFalse(foundItem);
        }

        [TestMethod]
        public void Remove_ItemExists_ReturnTrue()
        {
            //Arrange
            RakList<int> list = new RakList<int> { 0, 1, 2, 3, 4 };
            int input = 4;
            bool foundItem;

            //Act
            list.Remove(input);
            foundItem = true;

            //Assert
            Assert.IsTrue(foundItem);
        }

        [TestMethod]
        public void Remove_ItemExists_CheckIndex()
        {
            //Arrange
            RakList<int> list = new RakList<int> { 0, 1, 2, 3, 4 };
            int input = 2;

            //Act
            list.Remove(input);
            int expectedValue = 4;

            //Assert
            Assert.AreEqual(expectedValue, list[3]);
        }

        [TestMethod]
        public void Remove_ItemExists_CheckCount()
        {
            //Arrange
            RakList<int> list = new RakList<int>() { 0, 1, 2, 3, 4 };
            int input = 2;

            //Act
            list.Remove(input);
            int expectedValue = list.Count - 1;


            //Assert
            Assert.AreEqual(expectedValue, list.Count);
        }

        [TestMethod]
        public void ToString_CombineToSingle_MatchStrings()
        {
            //Arrange
            RakList<string> list = new RakList<string>() { "alpha", "bravo", "charlie", "delta" };
            string newString = "alpha, bravo,  charlie, and delta";

            //Act
            string testString = list.ToString();

            //Assert

            Assert.AreEqual(newString, testString);
            
        }

        [TestMethod]
        public void ToString_ListEmpty()
        {
            //Arrange
            RakList<string> list = new RakList<string>();
            string newString = " ";

            //Act
            string testString = list.ToString();

            //Assert
            Assert.AreEqual(newString, testString);
            
        }

        [TestMethod]
        public void OverloadOperator_CombineList_CheckContentsNewList()
        {
            //Arrange
            RakList<int> list1 = new RakList<int>() { 1, 2, 3, 4 };
            RakList<int> list2 = new RakList<int>() { 5, 6, 7, 8 };
            RakList<int> expectedResult = new RakList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Act
            RakList<int> newList = new RakList<int>();
            newList = list1 + list2;

            //Assert
            Assert.AreEqual(expectedResult, newList);
        }

        [TestMethod]
        public void OverloadOperator_CombineLists_CheckMatchingIndex()
        {
            //Arrange
            RakList<int> list1 = new RakList<int>() { 1, 2, 3, 4 };
            RakList<int> list2 = new RakList<int>() { 5, 6, 7, 8 };
            RakList<int> expectedResult = new RakList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Act
            RakList<int> newList = new RakList<int>();
            newList = list1 + list2;

            //Assert
            Assert.AreEqual(list1[1], expectedResult[1]);
        }

        [TestMethod]
        public void OverloadOperator_CombineLists_CompareCounts()
        {
            //Arrange
            RakList<int> list1 = new RakList<int>() { 1, 2, 3, 4 };
            RakList<int> list2 = new RakList<int>() { 5, 6, 7, 8 };
            RakList<int> expectedResult = new RakList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Act
            RakList<int> newList = new RakList<int>();
            newList = list1 + list2;

            //Assert
            Assert.AreEqual(list2[1], expectedResult[list1.Count + 2]);
        }

        [TestMethod]
        public void OverloadOpeator_CombineLists_CompareListCounts()
        {
            //Arrange
            RakList<int> list1 = new RakList<int>() { 1, 2, 3, 4 };
            RakList<int> list2 = new RakList<int>();

            //Act
            RakList<int> newList = new RakList<int>();
            newList = list1 + list2;

            //Assert
            Assert.AreEqual(list1.Count, newList.Count);
        }
    }
}
