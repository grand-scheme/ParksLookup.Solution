using Microsoft.AspNetCore.Mvc;
using ParksLookupClient.Models;
using System.Collections.Generic;

namespace ParksLookupClient.Controllers
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
