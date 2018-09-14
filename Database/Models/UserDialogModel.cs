using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class UserDialogModel
    {
        public int UserID { get; set; }

        public UserModel User {get;set;}

        public int DialogID { get; set; }

        public DialogModel Dialog { get; set; }
    }
}
