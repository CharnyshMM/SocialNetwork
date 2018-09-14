using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Interfaces;
using Database.Models;

namespace Database.Repositories
{
    public class UsersRepository : BaseRepository<UserModel>, IUsersRepository
    {
        public UsersRepository(DatabaseContext context) : base(context)
        {
        }

        public UserModel GetUserByUsername(string username)
        {
            return DbSet.Where(u => u.Credential.Username == username).Single();
        }
    }
}
