using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
    class ClaimProgramUI
    {

        public ClaimRepository _claimRepo = new ClaimRepository();

        public void Run()
        {
            SeedClaims();
            Menu();

        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Choose an option: \n" +
                    "1. See all claims \n" +
                    "2. Take care of next claim \n" +
                    "3. Enter a new claim \n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        _claimRepo.SeeAllClaimInformation();
                        break;



                    case "2":
                        Claim nextClaim= _claimRepo.GetNextClaim();
                        Console.WriteLine($"{nextClaim.ClaimAmount}, {nextClaim.ClaimDate}, {nextClaim.ClaimDescription}, {nextClaim.ClaimID}, {nextClaim.IncidentDate}, {nextClaim.IsValid}, {nextClaim.TypeOfClaim}");
                        Console.WriteLine("Do you want to take care of this claim now?");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            _claimRepo.DeleteClaim();
                            Console.WriteLine("Claim has been deleted");
                        }
                        else
                        {
                            Console.WriteLine("Claim could not be deleted and you cannot move to next item in queue.");
                        }


                        break;
                    case "3":
                        CreateNewClaim();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void CreateNewClaim()
        {
            Claim claim = new Claim();


            Console.WriteLine("Enter the claim ID:");
            claim.ClaimID = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter the claim type: \n" +
                "1. Car \n" +
                "2. Home \n" +
                "3.Theft");

            string claimAsString = Console.ReadLine();
            int claimAsInt = int.Parse(claimAsString);
            claim.TypeOfClaim = (ClaimType)claimAsInt;



            Console.WriteLine("Enter the claim description: ");
            claim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Enter the amount of damage:");
            claim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the accident date:");
            claim.IncidentDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the claim date:");
            claim.ClaimDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is the claim valid (y/n)");
            string claimValidity = Console.ReadLine().ToLower();
            if (claimValidity == "y")
            {
                claim.IsValid = true;
       
            }
            else
            {
                claim.IsValid = false;
            }

            _claimRepo.AddNewClaims(claim);

        }





        //when a claims agent needs to deal with an item they see the next item in the queue.
        //Do you want to deal with this claim now?
        //If yes, claim will be pulled off the top of the queue
        //if no, it will go back to main menu


        private void SeedClaims()
        {


            Claim ClaimOne = new Claim(1, "Car accident on 465", 400.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true, ClaimType.Car);
            Claim ClaimTwo = new Claim(2, "House fire in kitchen", 4000.00m, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12), true, ClaimType.Home);
            Claim ClaimThree = new Claim(3, "Stolen pancakes", 4.00m, new DateTime(2018, 04, 27), new DateTime(2018, 06, 18), false, ClaimType.Theft);

            _claimRepo.AddNewClaims(ClaimOne);
            _claimRepo.AddNewClaims(ClaimTwo);
            _claimRepo.AddNewClaims(ClaimThree);
        }
    }
}























