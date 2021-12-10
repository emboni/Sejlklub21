using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Exceptions;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Services
{
    public class BookingCatalog : IBookingCatalog
    {
        private string _filePath = "Data\\BookingCatalog.json";
        public void Add(IBooking booking)
        {
            if (booking.Journey.Start.CompareTo(booking.Journey.End) >= 0)
                throw new DateNotAfterDate("The booking ends before it starts");

            List<IBooking> bookings = GetAllBookings();
            booking.Id = bookings.Count == 0 ? 1 : bookings.Max(x => x.Id) + 1;
            bookings.Add(booking);
            Helpers.JsonFileWriter.WriteToJsonBooking(bookings, _filePath);
        }

        public void Update(IBooking booking)
        {
            if (booking.Journey.Start.CompareTo(booking.Journey.End) >= 0)
                throw new DateNotAfterDate("The booking ends before it starts");

            List<IBooking> bookings = GetAllBookings();
            bookings[bookings.FindIndex(x=>x.Id==booking.Id)] = booking;
            Helpers.JsonFileWriter.WriteToJsonBooking(bookings, _filePath);
        }

        public void Delete(int bookingId)
        {
            List<IBooking> bookings = GetAllBookings();
            bookings.RemoveAt(bookings.FindIndex(x => x.Id == bookingId));
            Helpers.JsonFileWriter.WriteToJsonBooking(bookings, _filePath);
        }

        public void MarkAsComplete(int bookingId)
        {
            IBooking b = GetBooking(bookingId);
            b.Completed = true;
            Update(b);
        }

        public IBooking GetBooking(int bookingId)
        {
            List<IBooking> bookings = GetAllBookings();
            return bookings[bookings.FindIndex(x => x.Id == bookingId)];
        }

        public List<IBooking> GetAllBookings()
        {
            return Helpers.JsonFileReader.ReadJsonBookings(_filePath);
        }
    }
}
