using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Min_Facebook.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Facebook.DAL.Contexts
{
    public class MinFbDbContext:IdentityDbContext<User>
    {
        public MinFbDbContext(DbContextOptions<MinFbDbContext> options):base(options)
        { 
        

        }

        public virtual DbSet<Post> Posts { get; set; }


    }
}
