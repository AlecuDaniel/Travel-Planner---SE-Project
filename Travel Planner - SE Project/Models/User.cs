using System.ComponentModel.DataAnnotations;

namespace Travel_Planner___SE_Project.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        public string Email { get; set; }

        public ICollection<SearchHistory>? SearchHistories { get; set; }
    }
}
