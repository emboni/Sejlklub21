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

        public string Username { get; set; }
        public string Password { get; set; }

        public bool Admin { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Number Required")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }

        public Member(int id, string username, string password, bool admin, string name, string email, string number, string address)
        {
            Id = id;
            Username = username;
            Password = password;
            Admin = admin;
            Name = name;
            Email = email;
            Number = number;
            Address = address;
        }

        public Member()
        {
            
        }

        public override bool Equals(object? obj)
        {
            if (((Member) obj).Id == this.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | Email: {Email} | Number: {Number} | Address: {Address}";
        }
    }
}