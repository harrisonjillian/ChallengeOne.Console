using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
    public class ClaimRepository
    {

        public Queue<Claim> _claims = new Queue<Claim>();




        //Add New Claims
        public void AddNewClaims(Claim newClaim)
        {
            _claims.Enqueue(newClaim);
        }


   
        //Delete New Claims

        public void DeleteClaim()
        {
            _claims.Dequeue();
        }

        //View Next Claim
        public Claim GetNextClaim()
        {
            //Declaring an instance of a claim that is the next claim in your _claims
            Claim nextClaim = _claims.Peek();
            return nextClaim;
         
        }




        //Get All Claims

        public Queue<Claim> GetAllClaims()
        {
            return _claims;
        }



        //SeeAllClaimInformation
        public Claim SeeAllClaimInformation()
        {
            foreach (Claim claim in _claims)
            {
                Console.WriteLine($"{claim.ClaimID}, {claim.TypeOfClaim}, {claim.ClaimDescription}, {claim.ClaimAmount}, {claim.IncidentDate}, {claim.ClaimDate}, {claim.IsValid}");
            }
            return null;

        }



        public Claim GetClaimsByClaimID(int claimID)
        {
            foreach (Claim newClaim in _claims)
            {
                if (newClaim.ClaimID == claimID)
                {
                    return newClaim;
                }
            }
            return null;
        }

        //UpdateClaimsbyClaim ID
        public bool UpdateClaimsByClaimID(int claimID, string claimDescription, decimal claimAmount, DateTime incidentDate, DateTime claimDate, bool isValid, ClaimType typeOfClaim)
        {
            Claim newClaimToBeUpdated = GetClaimsByClaimID(claimID);

            if (newClaimToBeUpdated != null)
            {
                newClaimToBeUpdated.ClaimID = claimID;
                newClaimToBeUpdated.ClaimDescription = claimDescription;
                newClaimToBeUpdated.ClaimAmount = claimAmount;
                newClaimToBeUpdated.IncidentDate = incidentDate;
                newClaimToBeUpdated.ClaimDate = claimDate;
                newClaimToBeUpdated.IsValid = isValid;
                newClaimToBeUpdated.TypeOfClaim = typeOfClaim;

                return true;
            }
            else
            {
                return false;
            }
        }

        








    }
}



