using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinderXAuth.Models
{
    public class Like
    {

        public int LikeId { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int? MindId { get; set; }
        public Mind Mind { get; set; }
    }
}
