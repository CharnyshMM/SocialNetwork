using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;
using Database.Interfaces;

namespace Database.Repositories
{
    public class PostsRepository : BaseRepository<PostModel>, IPostsRepository
    {
        public PostsRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
