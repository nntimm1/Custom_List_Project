using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        //---------------------------------------------Add Method Tests------------------------------------------------------------------
        [TestMethod]
        public void Add_CheckThatAddIsPlacingAtIndexOne()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            int actual;

            // Act
            customList.Add(5);
            actual = customList[0];


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncriments()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            int expected = 3;
            int actual;

            // Act
            customList.Add("flamingo");
            customList.Add("flamingo");
            customList.Add("flamingo");
            actual = customList.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToListWithItemsAlreadyInIt_NewItemGoesToLastIndex()
        {
            // Arrange
            CustomList<bool> customList = new CustomList<bool>();
            bool expected = false;
            bool actual;

            customList.Add(true);
            customList.Add(true);
            customList.Add(true);
            customList.Add(true);

            // Act
            customList.Add(false);
            actual = customList[4];


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToListWithItemsAlreadyInIt_CheckCountInArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 4;
            int actual;

            customList.Add(59);
            customList.Add(52);


            //Act
            customList.Add(55);
            customList.Add(48);
            actual = customList.Count;


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToListWithFullCapacity_CheckCapacityIncreasedOnceCapacityLimitReached()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 8;
            int actual;

            customList.Add(59);
            customList.Add(52);
            customList.Add(3);
            customList.Add(52);



            // Act
            customList.Add(3);
            customList.Add(55);

            actual = customList.Capacity;


            // Assert
            Assert.AreEqual(expected, actual);
        }
        //---------------------------------------------Remove Method Tests------------------------------------------------------------------

        [TestMethod]
        public void Remove_CheckCount_ThatRemoveDecreasingCountFromThreeToTwo()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            int actual;
            customList.Add(5);
            customList.Add(10);
            customList.Add(15);

            // Act
            customList.Remove(5);
            actual = customList.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_CheckIndexPosition_RemovingTheCorrectItemInArray_CheckIntAtIndexOneIsCorrect()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 10;
            int actual;
            customList.Add(5);
            customList.Add(10);
            customList.Add(15);

            // Act
            customList.Remove(5);
            actual = customList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_CheckCountZero_RemoveAllItemsFromListMakingCountZero()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            int expected = 0;
            int actual;
            customList.Add("flamingo");
            customList.Add("delta");
            customList.Add("tango");

            // Act
            customList.Remove("flamingo");
            customList.Remove("tango");
            customList.Remove("delta");
            actual = customList.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_CheckCount_RemovingIncorrectItemInArray()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;
            customList.Add(5);
            customList.Add(10);
            customList.Add(15);

            // Act
            customList.Remove(7);
            actual = customList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_CheckIndexLocation1_RemovingIncorrectItemInArray_ValidateIndexesDidNotChange()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 85;
            int actual;
            customList.Add(55);
            customList.Add(85);
            customList.Add(115);
            customList.Add(110);
            customList.Add(95);
            customList.Add(75);

            // Act
            customList.Remove(25);
            actual = customList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_CheckIndexLocation2_RemovingIncorrectItemInArray_ValidateIndexesDidNotChange()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 95;
            int actual;
            customList.Add(55);
            customList.Add(85);
            customList.Add(115);
            customList.Add(110);
            customList.Add(95);
            customList.Add(75);

            // Act
            customList.Remove(102);
            actual = customList[5];

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
