using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Database.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Services.Interfaces;
using SocialNetwork.ViewModels;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class FriendshipsController : Controller
    {
        IUsersService _usersService;
        IMapper _mapper;
        public FriendshipsController(IUsersService usersService, IMapper mapper)
        {
            _usersService = usersService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var userId = _usersService.GetUserIDByUsername(User.Identity.Name);
            ViewData["MyID"] = userId;
            
            var friendships = _usersService.GetUserFriends(userId);
            return View("Index", _mapper.Map<List<FriendshipViewModel>>(friendships));
        }

        public IActionResult NewFriendship(int id)
        {
            var myId = _usersService.GetUserIDByUsername(User.Identity.Name);
            _usersService.CreateFriendship(myId, id);
            return Redirect($"/UserProfile/UserProfile/{id}");
        }

        public IActionResult GetPeople(string name=null)
        {
          
            List<UserModel> users;
            if (name == null || name == "")
            {
                users = _usersService.GetUsers();
            }
            else
            {
                users = _usersService.GetUsersByPartialName(name);
            }
            return View("Search", _mapper.Map<List<UsersListItemViewModel>>(users));
        }
    }
} 