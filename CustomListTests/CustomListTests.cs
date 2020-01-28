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
            customList.Remove2(5);
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
            customList.Remove2(5);
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
            customList.Remove2("flamingo");
            customList.Remove2("tango");
            customList.Remove2("delta");
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
            customList.Remove2(7);
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
            customList.Remove2(25);
            actual = customList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
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
            customList.Remove2(102);
            actual = customList[4];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlus_AddingListTwoToTheEndOfListOne_CountValidate()
        {
            // Arrange
            CustomList<int> customList1 = new CustomList<int>() { 55, 85, 115, 35, 95 };
            CustomList<int> customList2 = new CustomList<int>() { 75, 65, 45, 105, 125 };
            
            int expected = 10;
            int actual;


            // Act
            CustomList<int> result = customList1 + customList2;
            actual = result.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlus_CheckIndexmatch_ValidatelocationOfAddedIndex()
        {
            // Arrange
            CustomList<int> customList1 = new CustomList<int>() {55, 85, 115, 35, 95 };
            CustomList<int> customList2 = new CustomList<int>() {75, 65, 45, 105, 125 };
            int expected = 65;
            int actual;


            // Act
            CustomList<int> result = customList1 + customList2;
            actual =result[6];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public object AddLists_AddTheCOntentsOfTwoLists_2Itemsand2Items()
        //{

        //    // Arrange
        //    CustomList<string> combinedList = new CustomList<string>();
        //    CustomList<string> customList1 = new CustomList<string>() {"Star", "Wars" };
        //    CustomList<string> customList2 = new CustomList<string>() { "Star", "Trek" };
        //    string expected = "Star Wars Star Trek";
        //    string actual;


        //    // Act
            

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
