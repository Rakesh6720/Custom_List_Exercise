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
            RakList<string> list = new RakList<string>() { "alpha", "bravo", "charlie", "delta"};

            string input = "echo";
            string actualResult = input;
            
            //Act
            list.Add(input);
            string expectedResult = list[4];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        
        public void Add_AddItemToFullList()
        {
            //Arrange
            RakList<int> list = new RakList<int>() { 0, 1, 2, 3, 4 };
            int input = 5;
            //Act
            list.Add(input);

            //Assert
            Assert.ThrowsException(IndexOutOfRangeException);//how will count and capacity be affected?  this should not be an exception.
        }

        [TestMethod]
        public void Remove_ItemFromEmptyList()
        {
            //Arrange
            RakList<string> list = new RakList<string>();
            string expectedValue = "referenceException";
            


            //Act
            list.Remove(actualValue);
            string actualValue = list[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue); // assert value throws error
        }

        [TestMethod]
        public void Remove_NonExistingItem(int num) //this is repetitive from the one above
        {
            //Arrange
            RakList<int> list = new RakList<int>() { 0, 1, 2, 3, 4 };
            int actualValue = 6;
            //Act
            list.Remove(actualValue);

            //Assert
            Assert.ThrowsException(IndexOutOfRangeException);
        }

        [TestMethod]
        public void Remove_MoreThanOneItemExists(string value)
        {
            //Arrange
            RakList<string> list = new RakList<string>() { "alpha", "bravo", "charlie", "delta", "echo", "alpha" };
            string expectedValue = "alpha";
            

            //Act
            list.Remove(value);
            string actualValue = list[4];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
