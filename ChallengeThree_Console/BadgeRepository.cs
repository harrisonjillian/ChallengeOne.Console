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

        // View All Badges

        public List<Badge> ViewAll()
        {
            List<Badge> listOfBadges = new List<Badge>();
            foreach (KeyValuePair<int, Badge> badge in badgeDictionary)
            {
                listOfBadges.Add(badge.Value);
            }
            return listOfBadges;
        }

        // Add Door to Badge

        public bool AddDoorToBadge(string doorName, int badgeID)
        {
            Badge addDoor = GetBadgeByID(badgeID);

            if(GetBadgeByID(badgeID) == null)
            {
                return false;
            }
            else
            {
                addDoor.DoorNames.Add(doorName);
                return true;
            }
        }

        public List<string> GetDoorsByList(int badgeID)
        {
            Badge seeDoors = GetBadgeByID(badgeID);
            if (seeDoors == null)
            {
                return null;
            }
            else
            {
                return seeDoors.DoorNames;
            }
        }


        // Delete Doors on Existing Badge 
        public bool DeleteDoorFromBadge(string removeDoorName, int badgeID)
        {
            Badge deleteDoor = GetBadgeByID(badgeID);

            if (GetDoorsByList(badgeID) == null)
            {
                return false;
            }

            foreach(string door in deleteDoor.DoorNames)
            {
                if (door == removeDoorName)
                {
                deleteDoor.DoorNames.Remove(removeDoorName);
                return true;

                }
            }
            return false;

        // Get Badge by ID
        }
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


    }
}












