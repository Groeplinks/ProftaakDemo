using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProftaakDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Thema()
        {
            List<IPost> posts = DummyRepositoryPost.GetAllPost();
            
            return View(posts);
        }
        public IActionResult Posts()
        {
            List<IPost> posts = DummyRepositoryPost.GetAllPost();

            return View(posts);
        }

        public IActionResult Comments()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreatePostPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Te gebruiken bij het aanmaken van een nieuwe post
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                DummyRepositoryPost.Add(post);
                
                return RedirectToAction("Posts");
            }

            return RedirectToAction("CreatePostPage");
        }
    }
}
