using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface IBookingCatalog
    {
        void Add(IBooking booking);

        void Update(IBooking booking);

        void Delete(int bookingId);

        IBooking GetBooking(int bookingId);

        List<IBooking> GetAllBookings();
    }
}
