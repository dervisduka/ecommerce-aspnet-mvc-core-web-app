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
            var allMovies = await _contex.Movies.ToListAsync();
            return View();
        }
    }
}
