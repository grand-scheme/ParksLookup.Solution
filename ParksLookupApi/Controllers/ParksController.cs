using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksLookupApiContext _db;
    public ParksController(ParksLookupApiContext db)
    {
      _db = db;
    }

    // GET API/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }

    // POST API/parks
    [HttpPost]
    public void Post ([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
  }
}