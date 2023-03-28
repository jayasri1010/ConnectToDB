using Microsoft.EntityFrameworkCore;

namespace ConnectToDB.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
                : base(options) { }
        public DbSet<userDetails> UsersDetails { get; set; }
    }
}
