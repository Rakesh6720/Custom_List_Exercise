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
        public void Add_AddItemToEmptyList(int num)
        {
            //Arrange
            RakList<int> list = new RakList<int>();
            int expectedResult = list[0];
            int ActualResult = 5;
            
            //Act
            list.Add(5);

            //Assert
            Assert.AreEqual(expectedResult, ActualResult);   
        }

        [TestMethod]
        public void Add_AddItemToList(string testValue)
        {
            //Arrange
            RakList<string> list = new RakList<string>() { "alpha", "bravo", "charlie", "dodge", "echo" };
            string expectedResult = list[5];
            string actualResult = testValue;
            
            //Act
            list.Add(testValue);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        
        public void Add_AddItemToFullList(int num)
        {
            //Arrange
            RakList<int> list = new RakList<int>() { 0, 1, 2, 3, 4 };    

            //Act
            list.Add(num);

            //Assert
            Assert.ThrowsException(IndexOutOfRangeException);
        }
    }
}
