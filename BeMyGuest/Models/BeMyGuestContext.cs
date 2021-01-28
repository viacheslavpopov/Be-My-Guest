using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeMyGuest.Models
{
    public class BeMyGuestContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Evidence> Evidences { get; set; }
        public DbSet<Gathering> Gathering { get; set; }
        public BeMyGuestContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}