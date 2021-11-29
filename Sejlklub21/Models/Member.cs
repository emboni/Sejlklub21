using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Member : IMember
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Number Required")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }

        public Member(int id, string name, string email, string number, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Number = number;
            Address = address;
        }

        public Member()
        {
            
        }

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | Email: {Email} | Number: {Number} | Address: {Address}";
        }
    }
}