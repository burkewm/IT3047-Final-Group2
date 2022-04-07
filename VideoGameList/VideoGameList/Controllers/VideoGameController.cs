using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameList.Controllers
{
    public class VideoGameController : Controller
    {
        private VideoGameContext context { get; set; }

        public VideoGameController(VideoGameContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.ESRB= context.ESRB.OrderBy(g => g.Name).ToList();
            return View("Edit", new VideoGame());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.ESRB = context.ESRB.OrderBy(g => g.Name).ToList();
            var game = context.Games.Find(id);
            return View(game);
        }
        [HttpPost]
        public IActionResult Edit(VideoGame game)
        {
            if (ModelState.IsValid)
            {
                if (game.VideoGameId == 0)
                    context.Games.Add(game);
                else
                    context.Games.Update(game);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (game.VideoGameId == 0) ? "Add" : "Edit";
                ViewBag.ESRB = context.ESRB.OrderBy(g => g.Name).ToList();
                return View(game);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }
        [HttpPost]
        public IActionResult Delete(VideoGame game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
