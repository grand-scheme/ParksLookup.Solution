using Microsoft.AspNetCore.Mvc;ParksLookupClient

namespace ParksLookup.Controllers
{
	public class HomeController : Controller
	{

		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}

	}
}
