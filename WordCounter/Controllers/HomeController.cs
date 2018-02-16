using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost("/wordcounter")]
        public ActionResult Results()
        {
            string userWord = Request.Form["word"];
            string userString= Request.Form["phrase"];

            RepeatCounter newRepeatCounter = new RepeatCounter(userWord, userString);
            return View("Index", newRepeatCounter);
        }

    }
}
