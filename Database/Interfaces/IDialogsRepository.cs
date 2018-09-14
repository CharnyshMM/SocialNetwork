using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;

namespace Database.Interfaces
{
    public interface IDialogsRepository: IRepository<DialogModel>
    {
        List<DialogModel> GetUserDialogsByUserID(int userId);
    }
}
