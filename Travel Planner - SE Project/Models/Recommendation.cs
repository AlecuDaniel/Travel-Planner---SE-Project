using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel_Planner___SE_Project.Models
{
    public class Recommendation
    {
        [Key]
        public int RecommendationId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Details { get; set; }

        public string Category { get; set; }

        [ForeignKey("Destination")]
        public int DestinationId { get; set; }

        public Destination? Destination { get; set; }
    }
}
