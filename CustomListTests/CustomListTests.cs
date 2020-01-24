using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_CheckThatAddIsPlaceingAtIndexOne()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 1;
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
            int expected = 1;
            int actual;

            // Act
            customList.Add("flamingo");
            actual = customList.count;


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
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 6;
            int actual;

            customList.Add(59);
            customList.Add(52);
            customList.Add(3);
            customList.Add(18);

            // Act
            customList.Add(55);
            customList.Add(48);
            actual = customList.count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Add_AddItemToListWithFullCapacity_CheckCapacityIncreasedOnceCapacityLimitReached()
        //{
        //    // Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int expected = 8;
        //    int actual;

        //    customList.Add(59);
        //    customList.Add(52);
        //    customList.Add(3);
        //    customList.Add(18);

        //    // Act
        //    customList.Add(55);
        //    customList.Add(48);
        //    actual = customList.Capacity;


        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

    }
}
