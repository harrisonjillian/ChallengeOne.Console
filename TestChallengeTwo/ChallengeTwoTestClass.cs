using System;
using System.Collections.Generic;
using ChallengeTwo_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallengeTwo
{
    [TestClass]
    public class ChallengeTwoTestClass
    {
        [TestMethod]
        public void NewClaimShouldBeAddedToBottomOfQueue()  // AddNewClaims
        {

            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), ClaimType.Car);

            //Act

            _repo.AddNewClaims(newClaim);
            int repoCount = _repo._claims.Count;


            //Assert

            Assert.AreEqual(1, repoCount);
        }


        [TestMethod]
        public void RemoveClaimFromQueue()  //DeleteClaims
        {

            //Arrange
            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act
            _repo.DeleteClaim();
            int repoCount = _repo._claims.Count;


            //Assert
            Assert.AreEqual(0, repoCount);

        }
        [TestMethod]
        public void ShowClaimAtBeginningWithoutRemoving() //ViewNextClaim 
        {

            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act

            _repo.GetAllClaims();
            int repoCount = _repo._claims.Count;


            //Assert

            Assert.AreEqual(1, repoCount);
        }


        [TestMethod]

        public void ReceiveAllClaims()  //GetAllClaims
        {

            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act

            Queue<Claim> seeAllClaims = _repo.GetAllClaims();

            //Assert

            Assert.AreEqual(1, seeAllClaims.Count);

        }

        [TestMethod]
        public void GetClaimsByIDAndReturnClaim() //GetClaimsByClaimID
        {
            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act

            Claim getClaim = _repo.GetClaimsByClaimID(024564);

            //Assert

            Assert.AreEqual(1000.50m, getClaim.ClaimAmount);
        }


        [TestMethod]
        public void UpdateClaimAndReturnRevisedClaim() //UpdateClaimByClaimID
        {

            //Arrange
            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), ClaimType.Car);
            _repo.AddNewClaims(newClaim);


            //Act
            bool claimUpdate = _repo.UpdateClaimsByClaimID(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), ClaimType.Car);

            //Assert
            Assert.AreEqual(true, claimUpdate);
        }
    }
}

