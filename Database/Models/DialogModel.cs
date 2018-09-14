using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class DialogModel
    {
        public int ID { get; set; }

        public List<UserDialogModel> DialogUsers { get; set; }

        public List<MessageModel> Messages { get; set; }
    }
}
