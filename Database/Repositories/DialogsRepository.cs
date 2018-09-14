using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;
using Database.Interfaces;
using System.Linq;

namespace Database.Repositories
{
    public class DialogsRepository : BaseRepository<DialogModel>, IDialogsRepository
    {
        public DialogsRepository(DatabaseContext context) : base(context)
        {
        }

        public List<DialogModel> GetUserDialogsByUserID(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
