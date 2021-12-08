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
        int BoatNum { get; set; }
        int MemberId { get; set; }
        Journey Journey { get; set; }
    }
}
