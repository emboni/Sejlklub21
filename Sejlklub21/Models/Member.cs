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

        public bool Admin { get; set; }

        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Username Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Number Required")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }

        public string ImageFileName { get; set; }

        public List<int> AllowedBoatTypes { get; set; }

        public Member(int id, bool admin, string email, string password, string username, string name, string number, string address, string imageFileName, List<int> allowedBoatTypes)
        {
            Id = id;
            Admin = admin;
            Email = email;
            Password = password;
            Username = username;
            Name = name;
            Number = number;
            Address = address;
            ImageFileName = imageFileName;
            AllowedBoatTypes = allowedBoatTypes;
        }

        public Member()
        {

        }

        public override bool Equals(object? obj)
        {
            if (((Member)obj).Id == this.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}