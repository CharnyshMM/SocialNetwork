using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.ViewModels
{
    public class DialogViewModel
    {
        public int ID { get; set; }

        public int AdresseeID { get; set; }

        public string Adressee { get; set; }
  
        public List<MessageViewModel> Messages { get; set; }
    }
}
