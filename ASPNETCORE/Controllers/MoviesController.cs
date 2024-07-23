using ASPNETCORE.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _contex;

        public MoviesController(AppDbContext context)
        {
            _contex = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _contex.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
