using Microsoft.AspNetCore.Mvc;ParksLookupClientParksLookupClient
using ParksLookup.Models;
using System.Collections.Generic;

namespace ParksLookup.Controllers
{
	public class ParksController : Controller
	{
		[HttpGet("/Parks")]
		public ActionResult Index()
		{
			return View();
		}
	}
}
