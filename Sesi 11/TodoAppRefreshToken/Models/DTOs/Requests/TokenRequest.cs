using System.ComponentModel.DataAnnotations;

namespace TodoAppRefreshToken.Models.DTOs.Requests{
    public class TokenRequest{
        [Required]
        public string token {get; set;}
        [Required]
        public string refreshToken {get; set;}
    }
}