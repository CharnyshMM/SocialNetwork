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
using AutoMapper;
using SocialNetwork.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ICredentialsRepository _credentialsRepository;
        private IUsersRepository _usersRepository;
        private IUsersService _usersService;
        private IMapper _mapper;

        public HomeController(ICredentialsRepository credentialsRepository,
                              IUsersRepository usersRepository,
                              IUsersService usersService,
                              IMapper mapper)
        {
            _credentialsRepository = credentialsRepository;
            _usersRepository = usersRepository;
            _usersService = usersService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            // later there should open a page of current user
            return View(
                "Index", 
                _mapper.Map<ViewModels.ProfileViewModel>(_usersService.GetUserByUserName(User.Identity.Name))
                );
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
