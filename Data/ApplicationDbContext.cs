using FreindsHub.Models;
using Microsoft.EntityFrameworkCore;

namespace FreindsHub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Friend> Friends { get; set; }
    }
}
