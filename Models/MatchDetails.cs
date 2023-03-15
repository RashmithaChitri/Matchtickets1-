using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matchtickets1.Models
{
    public class MatchDetails
    {
        internal static object id;

        public int Id { get; set; }
        [Required]
        public string StadiumName { get; set; }
        public string MatchName { get; set; }
        [Required]
        public DateTime MatchDate { get; set; }
        [Required]
        public string MatchTime { get; set; }
        public int TicketPrice { get; set; }
        public int NoOfTickets { get; set; }

    }
}
