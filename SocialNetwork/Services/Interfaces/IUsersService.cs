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

        List<UserModel> GetUsers();

        List<FriendshipModel> GetUserFriends(int userId);

        FriendshipModel GetFriendshipIfExists(int userId1, int userId2);

        void CreateFriendship(FriendshipModel friendship);

        void CreateFriendship(int userId1, int userId2);

        void RemoveFriendship(int friendshipId);
    }
}
