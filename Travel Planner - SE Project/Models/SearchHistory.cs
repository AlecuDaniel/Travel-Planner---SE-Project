using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel_Planner___SE_Project.Models
{
    public class SearchHistory
    {
        [Key]
        public int SearchHistoryId { get; set; }

        [Required]
        public string Query { get; set; }

        public DateTime SearchDate { get; set; } = DateTime.UtcNow;

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User? User { get; set; }
    }
}
