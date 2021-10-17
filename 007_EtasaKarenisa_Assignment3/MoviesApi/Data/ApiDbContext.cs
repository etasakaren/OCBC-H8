using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;
using MoviesApi.Data;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MoviesApi.Models.DTOs.Requests;

namespace MoviesApi.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<UserLoginRequest> UserLogin { get; set; }

        public DbSet<UserRegistrationDto> UserRegist { get; set; }
        public DbSet<ItemData> Items { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}