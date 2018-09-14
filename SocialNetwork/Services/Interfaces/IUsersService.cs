using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Services.Interfaces
{
    public interface IUsersService
    {
        UserModel GetUserByUserName(string userName);

        int GetUserIDByUsername(string userName);
    }
}
