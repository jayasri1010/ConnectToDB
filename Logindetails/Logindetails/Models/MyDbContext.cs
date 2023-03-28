using Microsoft.EntityFrameworkCore;
namespace Logindetails.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options):base(options) 
        { }
        public DbSet<UserDetails> usersDetails { get; set; }
    }
}
