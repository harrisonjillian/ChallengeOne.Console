using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
        public enum ClaimType
        {
            Car =1,
            Home,
            Theft
        }
    public class Claim
    {
        public int ClaimID { get; set; }

        public string ClaimDescription { get; set; }

        public decimal ClaimAmount { get; set; }

        public DateTime IncidentDate { get; set; }

        public DateTime ClaimDate{ get; set; } 

        public bool IsValid { get; set; }


        public ClaimType TypeOfClaim { get; set; }

        public Claim()
        {

        }

        public Claim(int claimID, string claimDescription, decimal claimAmount, DateTime incidentDate, DateTime claimDate, bool isValid, ClaimType typeOfClaim)
        {
            ClaimID = claimID;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            IncidentDate = incidentDate;
            ClaimDate = claimDate;
            IsValid = isValid;
            TypeOfClaim = typeOfClaim;
            

        }


    }


}


//Komodo allows an insurance claim to be made up to 30 days after an incident took place.If the claim is not in the proper time limit, it is not valid.

