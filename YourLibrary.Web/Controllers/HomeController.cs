using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourLibrary.Service;
using YourLibrary.Web.Models;

namespace YourLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService bookService;
        public HomeController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            var books = bookService.GetAll();
            return View(books);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
