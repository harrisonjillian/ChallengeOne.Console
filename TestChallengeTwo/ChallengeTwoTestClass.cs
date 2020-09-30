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
        public void NewClaimShouldBeAddedToBottomOfQueue()  //AddNewClaims
        {

            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), true, ClaimType.Car);

            //Act

            _repo.AddNewClaims(newClaim);
            int repoCount = _repo._claims.Count;  //Should I be using Enqueue instead of Count???  //Should I add two claims to know what order?


            //Assert

            Assert.AreEqual(1, repoCount);
        }

        [TestMethod]

        public void ShowClaimAtBeginningWithoutRemoving() //GetNextClaim 
        {

            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), true, ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act

            _repo.GetAllClaims();
            int repoCount = _repo._claims.Count;


            //Assert

            Assert.AreEqual(1, repoCount);
        }


        [TestMethod]

        public void ViewNewClaimsAndReturnClaimList()  //GetAllClaims
        {

            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), true, ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act

            Queue<Claim> seeClaims = _repo.GetAllClaims();

            //Assert

            Assert.AreEqual(1, seeClaims.Count);

        }

        [TestMethod]

        public void UpdateClaimAndReturnRevisedClaim() //UpdateClaimByClaimID
        {

            //Arrange
            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), true, ClaimType.Car);
            _repo.AddNewClaims(newClaim);


            //Act
            bool claimUpdate = _repo.UpdateClaimsByClaimID(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), true, ClaimType.Car);

            //Assert
            Assert.AreEqual(true, claimUpdate);

        }





        [TestMethod]

        public void RemoveClaimFromQueue()  //DeleteClaim
        {

            //Arrange
            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), true, ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act
            _repo.DeleteClaim();
            int repoCount = _repo._claims.Count;


            //Assert
            Assert.AreEqual(0, repoCount);

        }

        [TestMethod]
        public void GetClaimsByIDAndReturnClaim() //GetClaimsByClaimID
        {
            //Arrange

            ClaimRepository _repo = new ClaimRepository();
            Claim newClaim = new Claim(024564, "Car Accident", 1000.50m, new DateTime(2000, 8, 29), new DateTime(2000, 9, 14), true, ClaimType.Car);
            _repo.AddNewClaims(newClaim);

            //Act

            Claim getClaim = _repo.GetClaimsByClaimID(024564);

            //Assert

            Assert.AreEqual(1000.50, getClaim.ClaimAmount);


        }
    }
}

