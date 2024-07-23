﻿using ASPNETCORE.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _contex;

        public CinemasController(AppDbContext context)
        {
            _contex = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _contex.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
