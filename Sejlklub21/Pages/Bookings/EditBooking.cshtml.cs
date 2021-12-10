using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Exceptions;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Bookings
{
    public class EditBookingModel : PageModel
    {
        private ILoginService _loginService;
        private IBoatCatalog _boatCatalog;
        private IBookingCatalog _bookingCatalog;
        [BindProperty]
        public Models.Booking Booking { get; set; }

        public bool EndIsAfterStart { get; set; }
        public Journey PreExisting { get; set; }

        public EditBookingModel(ILoginService loginService, IBoatCatalog boatCatalog, IBookingCatalog bookingCatalog)
        {
            _loginService = loginService;
            _boatCatalog = boatCatalog;
            _bookingCatalog = bookingCatalog;
            EndIsAfterStart = true;
            PreExisting = null;
        }

        public void OnGet(int bookingId)
        {
            Booking = (Booking)_bookingCatalog.GetBooking(bookingId);
        }

        public IActionResult OnPost(int boatNum, int bookingId, int memberId)
        {
            #region Validations
            EndIsAfterStart = true;
            Booking.Id = bookingId;
            Booking.BoatNum = boatNum;
            Booking.MemberId = memberId;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var bookings = (from b in _bookingCatalog.GetAllBookings()
                where b.Id != bookingId
                where b.BoatNum == boatNum
                where b.Journey.End.CompareTo(Booking.Journey.Start) > 0 //removes those that have ended before this begins
                where b.Journey.Start.CompareTo(Booking.Journey.End) < 0 //removes those that start after this ends
                select b).ToArray();

            if (bookings.Length != 0)
            {
                PreExisting = bookings[0].Journey;
                return Page();
            }
            
            try
            {
                _bookingCatalog.Update(Booking);
            }
            catch (DateNotAfterDate)
            {
                EndIsAfterStart = false;
                return Page();
            }
            #endregion


            return RedirectToPage("/Bookings/MyBookings");
        }
    }
}
