using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface IMember
    {
        int Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Number { get; set; }
        string Address { get; set; }
    }
}