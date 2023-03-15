using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Matchtickets1.Models
{
    public class MatchticketBooking
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Registration")]
        public int RegistrationId { get; set; }
        [JsonIgnore]
        public virtual Registration Registration { get; set; }
        [Required]
        [ForeignKey("MatchDetails")]
        public int MatchdetailId { get; set; }
        [JsonIgnore]
        public virtual MatchDetails MatchDetails { get; set; }
        [Required]
        public int NoOfSeats { get; set; } 
        public int price { get; set; }
        
        



    }
}
