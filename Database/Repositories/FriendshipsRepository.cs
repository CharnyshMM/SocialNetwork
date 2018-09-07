using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Database.Interfaces;

namespace Database.Repositories
{
    public class FriendshipsRepository : BaseRepository<FriendshipModel>, IFriendshipRepository
    {
        public FriendshipsRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
