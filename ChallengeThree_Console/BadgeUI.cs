using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console
{
    public class BadgeUI
    {
        public BadgeRepository _badgeRepo = new BadgeRepository();

        public void Run()
        {
            SeedBadges();
            Menu();

        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Hello Security Admin, what would you like to do? \n" +
                    "1. Add a Badge \n" +
                    "2. Edit a Badge \n" +
                    "3. List all Badges \n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddBadgeToList();
                        break;

                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ViewAllBadges();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number (1 - 4)");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            }

        }

        public void AddBadgeToList()
        {

            Badge addBadge = new Badge();



            Console.WriteLine("Enter the badge number:");
            addBadge.BadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("List the door it needs access to:");
            string badgeInput = Console.ReadLine();

            List<Badge> listOfBadges = new List<Badge>();
            foreach (Badge item in listOfBadges)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Are there any other doors it needs access to? (y/n)");
            string doorAccess = Console.ReadLine().ToLower();

            if (doorAccess == "y")
            {
                Console.WriteLine("List the door it needs access to:");
                string answer = Console.ReadLine();
                Console.WriteLine("Thank you, badge has been added to list.");
            }
            else
            {
                Console.WriteLine("Thank you, Badge has been madded with access to the one door. Returning to main menu.");
            }

            _badgeRepo.AddNewBadgeToList(addBadge.BadgeID, addBadge);

        }

        public void UpdateBadge()
        {

            ViewAllBadges();

            Console.WriteLine("Enter the badge ID you would like to update:");
            string oldBadgeID = Console.ReadLine();

            Badge newDoorAccess = new Badge();
            Console.WriteLine("What would you like to do? \n" +
                "1. Remove a door. \n" +
                "2. Add a door");
            string newDoorAccessInput = Console.ReadLine();
           _badgeRepo.UpdateDoorOnBadge(newDoorAccess.BadgeID, newDoorAccess.DoorNames);

            if (oldBadgeID == "y")
            {
                Console.WriteLine("Which door would you like to remove?");
                string doorInput = Console.ReadLine();

                List<string> doorNames = new List<string>();
                foreach (string name in doorNames)
                {
                    Console.WriteLine($"Door Names: {doorNames}");
                }
                Console.WriteLine($"Thank you, {newDoorAccess.BadgeID} now only has access to {newDoorAccess.DoorNames}");
            }





            else
            {
                Console.WriteLine("Which door would you like to add?");
                // newDoorAccess.DoorNames = Console.ReadLine();
                Console.WriteLine($"Thank you, {newDoorAccess.BadgeID} now has additional access.  Doors accessed are {newDoorAccess.DoorNames}");
            }



        }

        public void ViewAllBadges()
        {
            List<Badge> listOfBadges = _badgeRepo.ViewAll();
            foreach (Badge badge in listOfBadges)
            {
                Console.WriteLine($"Badge ID: {badge.BadgeID}");
            }
            List<string> doorNames = new List<string>();
            foreach (string name in doorNames)
            {
                Console.WriteLine($"Door Names: {doorNames}");
            }

        }

        private void SeedBadges()
        {

            _badgeRepo.AddNewBadgeToList(2550, new Badge(2250, new List<string>() { "A5", "B23", "C198" }, "Wallace"));
            _badgeRepo.AddNewBadgeToList(4567, new Badge(4567, new List<string>() { "B5", "C23", "D293" }, "Smith"));
            _badgeRepo.AddNewBadgeToList(8895, new Badge(8895, new List<string>() { "G3", "A56", "D293" }, "Phillips"));

        }
    }
}


