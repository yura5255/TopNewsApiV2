using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.Entities;
using TopNewsApi.Core.Entities.Site;
using TopNewsApi.Core.Entities.Token;
using TopNewsApi.Core.Entities.User;
using TopNewsApi.Infrastructure.Initializers;

namespace TopNewsApi.Infrastructure.Context
{
    internal class AppDBContext : IdentityDbContext
    {
        public AppDBContext() : base() { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<NetworkAddress> NetworkAddresses { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedCategories();
            modelBuilder.SeedPosts();
            modelBuilder.SeedNetworkAddresses();

        }
    }
}
