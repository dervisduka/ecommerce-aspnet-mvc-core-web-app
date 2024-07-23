using ASPNETCORE.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _contex;

        public ProducersController(AppDbContext context)
        {
            _contex = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _contex.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
