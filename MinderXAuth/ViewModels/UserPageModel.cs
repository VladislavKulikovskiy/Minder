using MinderXAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinderXAuth.ViewModels
{
    public class UserPageModel
    {
        public User userPage { get; set; }
        public List<MindModel> userPageMinds { get; set; }

       public bool myFriend { get; set; }



    }
}