using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksApiContext _db;

    public ParksController(ParksApiContext db)
    {
      _db = db;
    }

    //GET: api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }

    // GET: api/parks/#id
    [HttpGet("{id}")]
    public ActionResult <Park> Get(int id)
    {
      return _db.Parks
        .FirstOrDefault(entry => entry.ParkId == id);
    }
    
    // POST: api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
    
    // PUT api/parks/#id
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/parks/#id
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var deletePark = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(deletePark);
      _db.SaveChanges();
    }
  }
}