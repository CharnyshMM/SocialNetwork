using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;
using Database.Interfaces;

namespace SocialNetwork.Services
{
    public class DialogsService
    {
        IUsersRepository _usersRepository;
        IDialogsRepository _dialogsRepository;
        IMessagesRepository _messagesRepository;

        public DialogsService(IUsersRepository usersRepository, IDialogsRepository dialogsRepository, IMessagesRepository messagesRepository)
        {
            _usersRepository = usersRepository;
            _dialogsRepository = dialogsRepository;
            _messagesRepository = messagesRepository;
        }

        public List<DialogModel> GetUserDialogs(string username)
        {
            var user = _usersRepository.GetUserByUsername(username);
            return _dialogsRepository.GetUserDialogsByUserID(user.ID);
        }

        public void CreateDialog(DialogModel dialog)
        {
            _dialogsRepository.Create(dialog);
        }
    }
}
