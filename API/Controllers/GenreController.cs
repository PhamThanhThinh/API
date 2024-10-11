using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  public class GenreController : Controller
  {
    private readonly ApplicationDbContext _db;

    public GenreController(ApplicationDbContext db)
    {
      _db = db;
    }

    [HttpGet("get-all")]
    public IActionResult GetAll()
    {
      return Ok(_db.Genres.ToList());
    }
  }
}
