using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;
using Database.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class DialogsRepository : BaseRepository<DialogModel>, IDialogsRepository
    {
        public DialogsRepository(DatabaseContext context) : base(context)
        {
        }

        public List<DialogModel> GetUserDialogs(int userID)
        {
            return DbSet.Where(d => d.AddresseeID == userID || d.InitiatorID == userID).ToList();
        }

        public DialogModel GetDialogWithMessages(int dialogID)
        {
            var item = GetItem(dialogID);
            Context.Entry(item).Collection(d => d.Messages).Load();
            return item;
        }
    }
}
