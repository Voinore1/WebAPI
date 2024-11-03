using Data.Entities;
using Data.Entities.VenichleInfo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Data
{
    public class AuctionDBContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public AuctionDBContext(DbContextOptions options) : base() { }
        public AuctionDBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored));

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cars&BidsDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuctionDBContext).Assembly);

        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Venichle> Venichles { get; set; }
        public DbSet<BodyStyle> BodyStyles { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
