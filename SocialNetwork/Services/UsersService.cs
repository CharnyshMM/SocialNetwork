using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;
using Database.Interfaces;
using SocialNetwork.Services.Interfaces;

namespace SocialNetwork.Services
{
    public class UsersService : IUsersService
    {
        IUsersRepository _usersRepository;
        ICredentialsRepository _credentialsRepository;

        public UsersService(IUsersRepository usersRepository, ICredentialsRepository credentialsRepository)
        {
            _usersRepository = usersRepository;
            _credentialsRepository = credentialsRepository;
        }

        public UserModel GetUserByUserName(string userName)
        {
            var cred = _credentialsRepository.GetUserCredentialsByUsername(userName);
            return _usersRepository.GetItem(cred.User.ID);
        }

        public int GetUserIDByUsername(string userName)
        {
            var cred = _credentialsRepository.GetUserCredentialsByUsername(userName);
            if (cred != null)
                return cred.UserID;
            throw new ArgumentException("No such username!!!!)))");
        }
    }
}
