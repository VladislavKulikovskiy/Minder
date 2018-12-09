using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinderXAuth.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public string ProfilePic { get; set; }
    }
}
