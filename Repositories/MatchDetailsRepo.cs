using Matchtickets1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Matchtickets1.Repositories
{
    public class MatchDetailsRepo : IMatchDetailsRepo
    {
        private readonly TicketBookingContext _context;
        public MatchDetailsRepo(TicketBookingContext context)
        {
            _context = context;
        }
        public List<MatchDetails> GetAllMatchDetails()
        {
            return _context.MatchDetails.ToList();
        }
        public MatchDetails GetMatchDetails(int id)
        {
            return _context.MatchDetails.FirstOrDefault(x => x.Id == id);
        }
        public string AddMatchDetails(MatchDetails matchDetails)
        {
            _context.MatchDetails.Add(matchDetails);
            _context.SaveChanges();
            if (matchDetails.Id > 0)
            {
                return "MatchDetails Successfull";
            }
            else
            {
                return "oops something went wrong ";
            }
        }
        public string UpdateMatchDetails(MatchDetails matchDetails)
        {
            _context.Entry(matchDetails).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchDetailsExists(matchDetails.Id))
                {
                    return "user not exist";
                }
                else
                {
                    return "oops something went wrong";
                }


            }
            return "updatedsuccessfully";
        }

        private bool MatchDetailsExists(int id)
        {
            return _context.MatchDetails.Any(e => e.Id == id);
        }

        public string DeleteMatchDetails(int id)
        {
            var x = _context.MatchDetails.SingleOrDefault(x => x.Id == id);
            if (x != null && x.Id > 0)
            {
                _context.MatchDetails.Remove(x);
                _context.SaveChanges();
                return "deletesuccessfully";
            }
            return "usernot exist";
        }
    }
}
        
           