using System;
using System.Collections.Generic;
using ChallengeThree_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallengeThree
{
    [TestClass]
    public class ChallengeThreeTestClass
    {
        [TestMethod]
        public void NewBadgeAddedToDictionary()  //Add New Badge Method
        {

            // Arrange

            BadgeRepository _repo = new BadgeRepository();
            Badge newBadge = new Badge(54, new List<string> { "A54", "B55", "C56" }, "Smith");

            // Act

            _repo.AddNewBadgeToList(newBadge.BadgeID, newBadge);
            int repoCount = _repo.badgeDictionary.Count;

            // Assert

            Assert.AreEqual(1, repoCount);

        }

        [TestMethod]

        public void ViewingAllBadgesInformationAndReturn()  // view All Method
        {

            // Arrange
            BadgeRepository _repo = new BadgeRepository();
            Badge newBadge = new Badge(54, new List<string> { "A54", "B55", "C56" }, "Smith");
            _repo.AddNewBadgeToList(newBadge.BadgeID, newBadge);

            // Act
            List<Badge> seeBadge = _repo.ViewAll();

            // Assert

            Assert.AreEqual(1, seeBadge.Count);
        }

        

        [TestMethod]

        public void DoorAddedToBadge() // Add doors to badge
        {
            ;
            // Arrange
            BadgeRepository _repo = new BadgeRepository();
            Badge newBadge = new Badge(54, new List<string> { "A54", "B55", "C56" }, "Smith");
            _repo.AddNewBadgeToList(newBadge.BadgeID, newBadge);

            // Act
            bool addDoor = _repo.AddDoorToBadge("A62", 54);


            // Assert
            Assert.AreEqual(true, addDoor);
        }

        [TestMethod]

        public void DoorDeletedFromBadge()  // Delete doors on badge 
        {
            // Arrange
            BadgeRepository _repo = new BadgeRepository();
            Badge newBadge = new Badge(54, new List<string> { "A54", "B55", "C56" }, "Smith");
            _repo.AddNewBadgeToList(newBadge.BadgeID, newBadge);

            // Act
            bool deleteDoor = _repo.DeleteDoorFromBadge("A54", 54);

            //Assert
            Assert.AreEqual(true, deleteDoor);

        }

        [TestMethod]

        public void DoorUpdatedOnExistingBadge()  // Get Doors By List
        {
            //Arrange
            BadgeRepository _repo = new BadgeRepository();
            Badge newBadge = new Badge(54, new List<string> { "A54", "B55", "C56" }, "Smith");
            _repo.AddNewBadgeToList(newBadge.BadgeID, newBadge);

            //Act

            List<string> seeDoor = _repo.GetDoorsByList(54);

            //Assert
            Assert.AreEqual(3, seeDoor.Count);
          

        }

        [TestMethod]

        public void BadgeReceivedByID()  // Get badge by ID
        {
            //Arrange
            BadgeRepository _repo = new BadgeRepository();
            Badge newBadge = new Badge(54, new List<string> { "A54", "B55", "C56" }, "Smith");
            _repo.AddNewBadgeToList(newBadge.BadgeID, newBadge);

            //Act
            Badge badgeFound = _repo.GetBadgeByID(54);

            //Assert
            Assert.AreEqual(54, badgeFound.BadgeID);
        }
    }
}
