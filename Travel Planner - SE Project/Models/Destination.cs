using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel_Planner___SE_Project.Models
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Country { get; set; }

        public string Description { get; set; }

        public string? ImageUrl { get; set; }

        
        public ICollection<Recommendation>? Recommendations { get; set; }
    }
}
