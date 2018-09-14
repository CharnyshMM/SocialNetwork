using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;
using Database.Interfaces;

namespace SocialNetwork.Services
{
    public class UsersService
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
    }
}
