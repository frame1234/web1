using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class contact
    {
        public string Name { get; set; }
        [EmailAeddress]
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool Sendcopy { get; set; }
    }
}
}
