using System.ComponentModel.DataAnnotations;

namespace FreindsHub.Models
{
    public class Friend
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string? NickName { get; set; }

        [StringLength(50)]
        public string? City { get; set; }
        [StringLength(150)]
        public string? FavouriteFood { get; set; }
        [StringLength(150)]
        public string? FavouriteMovie { get; set; }
        [Phone]

        public string? PhoneNumber { get; set; }


        public string? DateOfBirth { get; set; }

        public string FriendType { get; set; } = "Friend";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 


    }
}
