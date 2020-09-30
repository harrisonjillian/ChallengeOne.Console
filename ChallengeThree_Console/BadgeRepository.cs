using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console
{
    public class BadgeRepository
    {

        // Create Dictionary of Badges

        public Dictionary<int, Badge> badgeDictionary = new Dictionary<int, Badge>();


        // Add New Badge

        public void AddNewBadgeToList(int badgeID, Badge newBadge)
        {
            badgeDictionary.Add(badgeID, newBadge);
        }


        //Update Doors on Existing Badge --- HOW TO ADD DICTIONARY??

        public bool UpdateDoorOnBadge(int badgeID, List<string> doorNames)
        {
            Badge toBeUpdated = GetBadgeByID(badgeID);
            if (toBeUpdated != null)
            {
                toBeUpdated.DoorNames = doorNames;
                return true;

            }
            else
            {
                return false;
            }

        }


        // Helper Method - - - - - - Get Badge List By Door List

        public Badge GetBadgeByID(int badgeID)
        {
            foreach (Badge badge in badgeDictionary.Values)
            {
                if (badge.BadgeID == badgeID)
                {
                    return badge;
                }
            }
            return null;
        }



        //Delete Doors on Existing Badge (I DONT KNOW HOW TO PUT THE DICTIONARY IN HERE!!!)
        public bool DeleteAllDoorsFromBadge(int badgeID)
        {
            Badge badge = GetBadgeByID(badgeID);
            if (badge.DoorNames == null)
            {
                return false;
            }
            return true;
        }




        ////Display Badges -- DONT NEED ANYMORE
        //public void DisplayBadges()
        //{
        //    Badge badgesToDisplay = new Badge();
        //    foreach (KeyValuePair<int, Badge> Badge in badgeDictionary)
        //    {
        //        Console.WriteLine($"{Badge.Key} - {Badge.Value}");
        //    }
        //}


        //View All Badge Numbers & Door Access

        public List<Badge> ViewAll()
        {
            List<Badge> listOfBadges = new List<Badge>();
            foreach (KeyValuePair<int, Badge> badge in badgeDictionary)
            {
                listOfBadges.Add(badge.Value);
            }
            return listOfBadges;

        }
    }
}





