using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinderXAuth.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public int? Status { get; set; }

        public int USerOneId { get; set; }

        public int USerTwoId { get; set; }
    }
}
