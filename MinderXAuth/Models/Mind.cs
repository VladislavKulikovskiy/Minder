using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinderXAuth.Models
{
    public class Mind
    {
        public int MindId { get; set; }
        public string MindMess { get; set; }
        public int? NumOfLikes { get; set; }
        public DateTime? DateOfMind { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
