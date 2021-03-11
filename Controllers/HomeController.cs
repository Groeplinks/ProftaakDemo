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

        private readonly IPostRepository _postRepository;
        //dependency injection
        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Thema()
        {
            var model = _postRepository.GetAllPost();
            return View(model);
        }

        public IActionResult Comments()
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

        //Te gebruiken bij het aanmaken van een nieuwe post
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                Post newPost = _postRepository.Add(post);
                return RedirectToAction("Thema");
            }

            return View();
        }
    }
}
