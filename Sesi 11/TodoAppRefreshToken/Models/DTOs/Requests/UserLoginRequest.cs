using System.ComponentModel.DataAnnotations;

namespace TodoAppRefreshToken.Models.DTOs.Requests
{
    public class UserLoginRequest
    {
        [Required]
        [Key]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}