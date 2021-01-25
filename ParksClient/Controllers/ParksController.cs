namespace ParksClient.Controllers
{
  public class ParksController : Controller 
  {
    public IActionResult Index()
    {
      var allParks = Park.GetParks();
      return View(allParks);
    }
  }
}