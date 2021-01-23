using System.Collections.Generic; // if lists

namespace ParksLookupApi.Models
{
	public class Park
	{
		public int ParkId { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string NationalOrState { get; set; }
	}
}
