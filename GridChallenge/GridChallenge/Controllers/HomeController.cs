using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GridChallenge.Models;

namespace GridChallenge.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GameBoard boardGame = new GameBoard();
            return View(boardGame);
        }


        [HttpPost]
        public ActionResult RunGame(GameBoard model)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Is valid");
            }

            // something failed, redisplay form
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
