using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyProject.interfaces;
using StudyProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAllPosts _allPost;
        
          public HomeController(IAllPosts allPosts)
          {
              _allPost = allPosts;
          }
         public IActionResult List()
          {
              var posts = _allPost;
              return View(posts );
          }
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
