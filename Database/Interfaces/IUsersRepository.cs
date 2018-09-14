﻿using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Interfaces
{
    public interface IUsersRepository : IRepository<UserModel>
    {
        UserModel GetUserByUsername(string username);
    }
}
