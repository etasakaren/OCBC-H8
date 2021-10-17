using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models.DTOs.Requests
{
    public class UserRegistrationDto
    {
        [Required]
        public string username { get; set; }
        [Required]
        [Key]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}