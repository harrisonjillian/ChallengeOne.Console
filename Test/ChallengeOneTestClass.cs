using System;
using System.Collections.Generic;
using ChallengeOne_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallengeOne
{
    [TestClass]
    public class ChallengeOneTestClass
    {
        [TestMethod]
        public void CreateShouldIncreaseRepoCount ()  //Create Method Test
        {


            //Arrange
            MenuRepository _repo = new MenuRepository();
            Menu menu = new Menu("Vegetable Burger", "vegetable burger with veggies", 5.00m, new List<string> { "chickpeas", "onions", "peppers" }, 4);
            
            //Act
            _repo.CreateNewMenuItems(menu);
            int repoCount = _repo._menuItems.Count;

            //Assert
            Assert.AreEqual(1, repoCount);
        }

        [TestMethod]
        public void DeleteShouldReduceRepoCount()  //Delete Method Test
        {

            //Arrange
            MenuRepository _repo = new MenuRepository();
            Menu menu = new Menu("Vegetable Burger", "vegetable burger with veggies", 5.00m, new List<string> { "chickpeas", "onions", "peppers" }, 4);
            _repo.CreateNewMenuItems(menu);

            //Act
            bool menuDelete = _repo.RemoveMenuItemsFromInventory("Vegetable Burger");

            //Assert
            Assert.AreEqual(true, menuDelete);

        }

        [TestMethod]

        public void FindMenuInListReturnsProperItem()  //Helper Method Test
        {
            //Arrange
            MenuRepository _repo = new MenuRepository();
            Menu menu = new Menu("Vegetable Burger", "vegetable burger with veggies", 5.00m, new List<string> { "chickpeas", "onions", "peppers" }, 4);
            _repo.CreateNewMenuItems(menu);

            //Act
            Menu menufound = _repo.GetMenuFromList("Vegetable Burger");

            //Assert
            Assert.AreEqual(4, menufound.MealNumber);
            

        }

        [TestMethod]

        public void ViewMenuItemsAndReturnList()  //Read Method Test
        {
            MenuRepository _repo = new MenuRepository();
            Menu menu = new Menu("Vegetable Burger", "vegetable burger with veggies", 5.00m, new List<string> { "chickpeas", "onions", "peppers" }, 4);
            _repo.CreateNewMenuItems(menu);

            //Act
            List<Menu> seeMenu = _repo.ViewMenuItems();

            //Assert
            Assert.AreEqual(1, seeMenu.Count);

        }
       
    }
}
