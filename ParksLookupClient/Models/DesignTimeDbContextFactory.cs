using Microsoft.EntityFrameworkCore;ParksLookupClientParksLookupClientParksLookupClientParksLookupClientParksLookupClientParksLookupClientParksLookupClient
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ParksLookup.Models{
	public class ParksLookupContextFactory : IDesignTimeDbContextFactory<ParksLookupContext>
	{
		ParksLookupContext IDesignTimeDbContextFactory<ParksLookupContext>.CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			
			var builder = new DbContextOptionsBuilder<ParksLookupContext>();
			var connectionString = configuration.GetConnectionString("DefaultConnection");

			builder.UseMySql(connectionString);

			return new ParksLookupContext(builder.Options);
		}
	}
}
