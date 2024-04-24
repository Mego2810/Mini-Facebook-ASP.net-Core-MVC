using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Min_Facebook.DAL.Models;

namespace Min_Facebook.DAL.Contexts
{
    public class MinFbDbContext : IdentityDbContext<User>
    {
        public MinFbDbContext(DbContextOptions<MinFbDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
