using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinderXAuth.Models
{
    public class MinderXAContext: DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Mind> Minds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Like> Likes { get; set; }


        public MinderXAContext(DbContextOptions<MinderXAContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
