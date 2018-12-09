using MinderXAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinderXAuth.ViewModels
{
    public class MindModel
    {
        public int MindId { get; set; }
        public string MindMess { get; set; }
        public int? NumOfLikes { get; set; }
        public DateTime? DateOfMind { get; set; }
        public int UserId { get; set; }
        public bool liked { get; set; }
        //public List<Comment> Comments { get; set; }
        public Dictionary<Comment, String> Comments2 { get; set; }

        public string UserPic { get; set; }
    }
}
