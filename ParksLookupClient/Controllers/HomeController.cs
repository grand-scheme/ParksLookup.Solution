using Microsoft.AspNetCore.Mvc;

namespace ParksLookupClient.Controllers
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
