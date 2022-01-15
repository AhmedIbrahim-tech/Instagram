using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Instagram.Areas.Identity.Data;
using Instagram.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Instagram.Data
{
    public class InstagramContext : IdentityDbContext<InstagramUser>
    {
        public InstagramContext(DbContextOptions<InstagramContext> options)
            : base(options)
        {
        }

        public DbSet<Chat> chats { get; set; }
        public DbSet<Follow> follows { get; set; }
        public DbSet<Like> likes { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Seen> seens { get; set; }
        public DbSet<Story> stories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
