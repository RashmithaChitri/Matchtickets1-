using log4net.Core;
using Microsoft.EntityFrameworkCore;

namespace Matchtickets1.Models
{
    public class TicketBookingContext : DbContext
    {
        
        public TicketBookingContext(DbContextOptions<TicketBookingContext> options) : base(options) { }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<MatchticketBooking> MatchticketBookings { get; set; }
        public DbSet<MatchDetails> MatchDetails { get; set; }

    }
}
 
 