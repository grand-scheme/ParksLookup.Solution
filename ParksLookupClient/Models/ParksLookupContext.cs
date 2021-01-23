using Microsoft.EntityFrameworkCore;

namespace ParksLookupClient.Models{
	public class ParksLookupContext : DbContext{
		public DbSet<Park> Parks {get; set;}
		public ParksLookupContext(DbContextOptions options) : base(options) { }
	}
}
