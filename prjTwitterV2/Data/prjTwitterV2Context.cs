using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prjTwitterV2.Models;

namespace prjTwitterV2.Data
{
    public class prjTwitterV2Context : DbContext
    {
        public prjTwitterV2Context (DbContextOptions<prjTwitterV2Context> options)
            : base(options)
        {
        }

        public DbSet<prjTwitterV2.Models.User> Users { get; set; }
        public DbSet<prjTwitterV2.Models.Tweet> Tweets { get; set; }
        public DbSet<prjTwitterV2.Models.Follow> Follows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Follow>()
                .HasKey(nameof(Follow.FollowerUsername), nameof(Follow.FollowingUsername));
        }
    }
}
