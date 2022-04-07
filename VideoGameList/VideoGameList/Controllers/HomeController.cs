using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using VideoGameList.Models;

namespace VideoGameList.Controllers
{
    public class HomeController : Controller
    {
        private VideoGameContext context { get; set; }

        public HomeController(VideoGameContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var games = context.Games
                .Include(g => g.ESRB)
                .OrderBy(m => m.Title).ToList();
            return View(games);
        }
    }
}
