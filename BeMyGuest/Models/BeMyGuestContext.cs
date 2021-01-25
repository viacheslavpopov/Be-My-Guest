using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeMyGuest.Models
{
    public class BeMyGuestContext : IdentityDbContext<Host, Guest>
    {
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Gathering> Gatherings { get; set; }
        public DbSet<CovidData> CovidDataSet { get; set; }
        public BeMyGuestContext(DbContextOptions options) : base (options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}