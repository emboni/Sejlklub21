using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Models
{
    public class Member
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private string Number { get; set; }

        public Member(string name, string email, string number)
        {
            Name = name;
            Email = email;
            Number = number;
        }
    }
}