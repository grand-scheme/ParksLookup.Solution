using Microsoft.EntityFrameworkCore;ParksLookupClientParksLookupClient

namespaceParksLookupClientp.Models{
	public class ParksLookupContext : DbContext{
		public DbSet<Park> Parks {get; set;}
		public ParksLookupContext(DbContextOptions options) : base(options) { }
	}
}
