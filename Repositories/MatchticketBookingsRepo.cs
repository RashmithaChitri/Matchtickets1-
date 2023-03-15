using Matchtickets1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Matchtickets1.Repositories
{
    public class MatchticketBookingsRepo :IMatchticketBookingsRepo
    {
        private readonly TicketBookingContext _context;
        public MatchticketBookingsRepo(TicketBookingContext context)
        {
            _context = context;
        }
        public List<MatchticketBooking> GetAllMatchticketBookings()
        {
            return _context.MatchticketBookings.ToList();
        }
        public MatchticketBooking GetMatchticketBookingsById(int id)
        {
            return _context.MatchticketBookings.SingleOrDefault(b => b.Id == id);
        }
        public string AddnewMatchticketBooking(MatchticketBooking booking)
        {
            _context.MatchticketBookings.Add(booking);
            _context.SaveChanges();
            if (booking.Id > 0)
            {
                return "MatchticketBookings Successfull";
            }
            else
            {
                return "oops something went wrong";
            }
        }
        public string UpdateMatchticketBooking(MatchticketBooking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchticketBookingExists(booking.Id))
                {
                    return "User not exist";
                }
                else
                {
                    throw;
                }
            }
            return "updatesuccessfully";
        }
        private bool MatchticketBookingExists(int id)
        {
            return _context.MatchticketBookings.Any(e => e.Id == id);
        }
        public string DeleteMatchticketBooking(int id)
        {
            var x = _context.MatchticketBookings.SingleOrDefault(e => e.Id == id);
            if(x != null && x.Id > 0) 
            {
                _context.MatchticketBookings.Remove(x);
                _context.SaveChanges();
                return "deletedsuccessfully";

            }
            return "usernot exist";

        }


    }
}
