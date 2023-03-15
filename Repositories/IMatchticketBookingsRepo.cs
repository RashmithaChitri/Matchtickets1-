using Matchtickets1.Models;
using System.Collections.Generic;

namespace Matchtickets1.Repositories
{
    public interface IMatchticketBookingsRepo
    {
        List<MatchticketBooking> GetAllMatchticketBookings();
        MatchticketBooking GetMatchticketBookingsById(int id);
        string AddnewMatchticketBooking(MatchticketBooking booking);
        string UpdateMatchticketBooking( MatchticketBooking booking);
        string DeleteMatchticketBooking(int id);

    }
}
