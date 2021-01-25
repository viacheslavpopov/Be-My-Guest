using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BeMyGuest.Models
{
    public class BeMyGuestContextFactory : IDesignTimeDbContextFactory<BeMyGuestContext>
    {
        BeMyGuestContext IDesignTimeDbContextFactory<BeMyGuestContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BeMyGuestContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new BeMyGuestContext(builder.Options);
        }
    }
}