using Microsoft.EntityFrameworkCore;

namespace restApi.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}