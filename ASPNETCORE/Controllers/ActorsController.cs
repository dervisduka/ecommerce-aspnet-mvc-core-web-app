using ASPNETCORE.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCORE.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _contex;

        public ActorsController(AppDbContext context)
        {
            _contex = context;
        }

        public IActionResult Index()
        {
            var data = _contex.Actors.ToList();
            return View(data);
        }
    }
}
