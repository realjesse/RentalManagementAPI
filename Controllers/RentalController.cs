using Microsoft.AspNetCore.Mvc;

namespace RentalManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RentalController : Controller
{
    // list
    private static List<Rental> rentals = new List<Rental>();
    
    // GET
    [HttpGet]
    public ActionResult<List<Rental>> GetRentals()
    {
        return Ok(rentals);
    }
    
    // Rent a movie
    [HttpPost]
    public ActionResult RentMovie(Rental rental)
    {
        rental.Id = rentals.Count + 1;
        rentals.Add(rental);
        return Ok("Movie rented!");
    }
    
    // Return a movie
    [HttpPost("{id}")]
    public ActionResult ReturnMovie(int id)
    {
        var movie = rentals.FirstOrDefault(r => r.Id == id);
        if (movie == null)
        {
            return NotFound("Movie not found!");
        }
        rentals.Remove(movie);
        return Ok("Movie returned!");
    }
    
}