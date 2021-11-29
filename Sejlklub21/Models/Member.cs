using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Member : IMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }

        public Member(int id, string name, string email, string number, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Number = number;
            Address = address;
        }

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | Email: {Email} | Number: {Number} | Address: {Address}";
        }
    }
}