using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Interfaces;
using Database.Models;
using SocialNetwork.Services.Interfaces;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class UserDialogsController: Controller
    {
        IDialogsService _dialogsService;
        IUsersService _usersService;

        public UserDialogsController(IDialogsService dialogsService, IUsersService usersService )
        {
            _dialogsService = dialogsService;
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            int userID = _usersService.GetUserIDByUsername(User.Identity.Name);
            return View(_dialogsService.GetUserDialogs(userID));
        }

        //[HttpGet("{id}")]
        //public ActionResult<DialogModel> Dialog(int id)
        //{
        //    var username = User.Identity.Name;
        //    var userCredentials = _credentialsRepository.GetUserCredentialsByUsername(username);
        //    var userDialogs = _dialogsRepository.GetUserDialogsByUserID(userCredentials.UserID);
        //    return new ObjectResult(userDialogs.Find(d => d.ID == id));
        //}

        public IActionResult NewDialog(DialogModel dialog)
        {
            dialog.Initiator = _usersService.GetUserByUserName(User.Identity.Name);
            _dialogsService.CreateDialog(dialog);
            return View(dialog);
        }

        public IActionResult Dialog(int id)
        {
            var dialog = _dialogsService.GetDialog(id);
            return View(dialog);
        }
    }
}
