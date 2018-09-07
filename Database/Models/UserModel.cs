using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        public List<FriendshipModel> Friends { get; set; }

        public List<FriendshipModel> FriendOf { get; set; }

        public List<MessageModel> Messages { get; set; }

        //public int CredentialID { get; set; }

        public CredentialModel Credential { get; set; } // primary

        public List<PostModel> Posts { get; set; }
    }
}