using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}