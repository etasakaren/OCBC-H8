using Microsoft.EntityFrameworkCore;
using TodoAppRefreshToken.Models;
using TodoAppRefreshToken.Data;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TodoAppRefreshToken.Models.DTOs.Requests;

namespace TodoAppRefreshToken.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<UserLoginRequest> UserLogin { get; set; }

        public DbSet<UserRegistrationDto> UserRegist { get; set; }
        public DbSet<ItemData> Items { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}