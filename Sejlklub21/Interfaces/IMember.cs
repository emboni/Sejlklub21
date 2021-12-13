using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface IMember
    {
        int Id { get; set; }

        bool Admin { get; set; }

        string Email { get; set; }
        string Password { get; set; }

        string Username { get; set; }
        string Name { get; set; }
        string Number { get; set; }
        string Address { get; set; }

        string ImageFileName { get; set; }

        List<int> AllowedBoatTypes { get; set; }
    }
}