using Microsoft.EntityFrameworkCore;
using PlatformService;

namespace PlatformServices.data
{
    public class AppDbContext : DbContext{

        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }
        public DbSet<Platform> Platforms { get; set; }
    }
}