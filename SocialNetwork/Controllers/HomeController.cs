using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Models;
using Database.Models;
using Database.Interfaces;
using Database.Interfaces;
using Database.Models;
using Microsoft.AspNetCore.Authorization;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ICredentialsRepository _credentialsRepository; 
        public HomeController(ICredentialsRepository credentialsRepository)
        {
            _credentialsRepository = credentialsRepository;
        }

        public IActionResult Index()
        {
            // later there should open a page of current user
            var li = _credentialsRepository.GetItems();

            var u2 = new UserModel
            {
                Name = $"{User.Identity.Name} - current!!!"
            };
            return View(new List<UserModel> {u2});
        }

        public IActionResult About()
        {
            ViewData["Message"] = User.Identity.Name;

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
