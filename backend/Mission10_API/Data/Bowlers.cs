using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_API.Data
{
    public class Bowlers
    {
        [Key]
        public int BowlerID { get; set; } // Primary key (assuming you have an ID)

        [Required]
        public string BowlerFirstName { get; set; }

        public string? BowlerMiddleInit { get; set; }

        [Required]
        public string BowlerLastName { get; set; }

        [ForeignKey("TeamName")]

        public int TeamID { get; set; }
        public Teams TeamName { get; set; }

        [Required]
        public string BowlerAddress { get; set; }

        [Required]
        public string BowlerCity { get; set; }

        [Required]
        public string BowlerState { get; set; }

        [Required]
        public string BowlerZip { get; set; }

        [Required]
        public string BowlerPhoneNumber { get; set; }
    }
}

