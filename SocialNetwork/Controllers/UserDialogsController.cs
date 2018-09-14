using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Interfaces;
using Database.Models;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class UserDialogsController: Controller
    {
        IDialogsRepository _dialogsRepository;
        ICredentialsRepository _credentialsRepository;

        public UserDialogsController(IDialogsRepository dialogsRepository, ICredentialsRepository credentialsRepository)
        {
            _dialogsRepository = dialogsRepository;
            _credentialsRepository = credentialsRepository;
        }

        //public IActionResult Index()
        //{
        //    var username = User.Identity.Name;
            
        //}

        //[HttpGet("{id}")]
        //public IActionResult Dialog(int id)
        //{

        //}
    }
}
