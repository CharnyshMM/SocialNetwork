using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Services.Interfaces;
using SocialNetwork.ViewModels;

namespace SocialNetwork.Controllers
{
    public class UserProfileController : Controller
    {
        IUsersService _usersService;
        IMapper _mapper;

        public UserProfileController(IUsersService usersService, IMapper mapper)
        {
            _usersService = usersService;
            _mapper = mapper;
        }

        public ActionResult UserProfile(int id)
        {
            int myId = _usersService.GetUserIDByUsername(User.Identity.Name);
            var user = _usersService.GetUserById(id);
            bool isFriendOfCurrentUser = _usersService.GetFriendshipIfExists(id, myId) != null;
            var profile = _mapper.Map<UserProfileViewModel>(user, opts => opts.Items["IsFriend"] = isFriendOfCurrentUser);
            return View("UserProfile", profile);
        }
    }
}