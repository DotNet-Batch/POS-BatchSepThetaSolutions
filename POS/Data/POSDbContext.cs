using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POS.Models;

namespace POS.Data
{
    public class POSDbContext : IdentityDbContext
    {
        public POSDbContext(DbContextOptions<POSDbContext> options)
            : base(options)
        {
        }
        public DbSet<Items> Items { get; set; } 
    }
}