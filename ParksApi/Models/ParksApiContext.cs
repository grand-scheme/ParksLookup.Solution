using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public ParksApiContext(DbContextOptions<ParksApiContext> options)
    : base(options)
    {}

    public DbSet<Park> Parks {get;set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
        new Park {
          ParkId = 1, Name = "Mount Rainier", State = "Washington", StateOrNational = "National"
        },
        new Park {
          ParkId = 2, Name = "North Cascades", State = "Washington", StateOrNational = "National"
        },
        new Park {
          ParkId = 3, Name = "Olympic", State = "Washington", StateOrNational = "National"
        },
        new Park {
          ParkId = 4, Name = "Crater Lake", State = "Oregon", StateOrNational = "National"
        },
        new Park {
          ParkId = 5, Name = "test2", State = "Oregon", StateOrNational = "State"
        }
      );
    }
  }
}