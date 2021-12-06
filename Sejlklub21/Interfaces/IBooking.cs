using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Models;

namespace Sejlklub21.Interfaces
{
    public interface IBooking
    {
        int Id { get; set; }
        IBoat Boat { get; set; }
        IMember Member { get; set; }
        Journey Journey { get; set; }
    }
}
