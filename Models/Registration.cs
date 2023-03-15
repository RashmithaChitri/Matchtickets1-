using System.ComponentModel.DataAnnotations;

namespace Matchtickets1.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public bool IsAdmin { get; set; }


    }
}
