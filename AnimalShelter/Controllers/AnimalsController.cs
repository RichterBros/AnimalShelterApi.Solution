using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    //GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
        return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }
    
    //GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string species, string gender, string name, int age )
    {
        var query = _db.Animals.AsQueryable();

        if (species != null)
        {
        query = query.Where(entry => entry.Species == species);
        }

        if (gender != null)
        {
        query = query.Where(entry => entry.Gender == gender);
        }

        if (name != null)
        {
        query = query.Where(entry => entry.Name == name);
        }

        if (age != 0)
        {
        query = query.Where(entry => entry.Age == age);
        }
        return query.ToList();
    }   
    
    //Pagination
    [HttpGet("page")]
    public ActionResult GetPage([FromQuery] UrlQuery urlQuery)
    {
        var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
        var pagedData = _db.Animals
            .OrderBy(animal => animal.AnimalId)
            .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
            .Take(validUrlQuery.PageSize);
        return Ok(pagedData);
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }
  
    // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
        animal.AnimalId = id;
        _db.Entry(animal).State = EntityState.Modified;
        _db.SaveChanges();
    }
  
      // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  
  
  }
}