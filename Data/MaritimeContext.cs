using MaritimeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MaritimeAPI.Data
{
    public class MaritimeContext : DbContext
    {
        public MaritimeContext(DbContextOptions<MaritimeContext> options) : base(options) { 
        }

        public DbSet<Ship> Ships { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<Voyage> Voyages { get; set; }
        public DbSet<CountryVisited> CountriesVisited { get; set; }
    }
}
