using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Interfaces;
using Database.Models;
using Microsoft.EntityFrameworkCore;

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

        public List<UserModel> GetUsersByPartialName(string name)
        {
            return DbSet.Where(u => u.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
