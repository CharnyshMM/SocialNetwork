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
    public class UserProfileController : Controller
    {
        IUsersService _usersService;
        IMapper _mapper;

        public UserProfileController(IUsersService usersService, IMapper mapper)
        {
            _usersService = usersService;
            _mapper = mapper;
        }

        public IActionResult UserProfile(int id)
        {
            int myId = _usersService.GetUserIDByUsername(User.Identity.Name);
            var user = _usersService.GetUserById(id);
            bool isFriendOfCurrentUser = _usersService.GetFriendshipIfExists(id, myId) != null;
            var profile = _mapper.Map<UserProfileViewModel>(user, opts => opts.Items["IsFriend"] = isFriendOfCurrentUser);
            return View("UserProfile", profile);
        }

        [HttpGet]
        public IActionResult UpdateProfile()
        {
            int myId = _usersService.GetUserIDByUsername(User.Identity.Name);
            var user = _usersService.GetUserById(myId);
            return View("UpdateProfile", user);
        }

        [HttpPut]
        public IActionResult UpdateProfile(UserProfileViewModel userProfile)
        {
            int myId = _usersService.GetUserIDByUsername(User.Identity.Name);
            userProfile.ID = myId;
            _usersService.UpdateUser(_mapper.Map<UserModel>(userProfile));
            return View("UserProfile", userProfile);
        }
    }
}