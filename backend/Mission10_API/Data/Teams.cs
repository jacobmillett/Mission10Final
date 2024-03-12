using System.ComponentModel.DataAnnotations;

namespace Mission10_API.Data
{
    public class Teams
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        public string TeamName { get; set; }
    }
}
