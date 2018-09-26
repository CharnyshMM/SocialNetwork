using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Services.Interfaces;

namespace SocialNetwork.Controllers
{
    public class FriendshipsController : Controller
    {
        IUsersService _usersService;
        public FriendshipsController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            var userId = _usersService.GetUserIDByUsername(User.Identity.Name);
            
            return View("Index", _usersService.GetUserFriends(userId));
        }

        public IActionResult NewFriendship(int otherUserId)
        {
            var myId = _usersService.GetUserIDByUsername(User.Identity.Name);
            _usersService.CreateFriendship(myId, otherUserId);
            return Index();
        }
    }
}