using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Exceptions;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Boats
{
    public class CreateBookingModel : PageModel
    {
        private ILoginService _loginService;
        private IBoatCatalog _boatCatalog;
        private IBookingCatalog _bookingCatalog;
        [BindProperty] 
        public Models.Booking Booking { get; set; }

        public bool EndIsAfterStart { get; set; }
        public Journey PreExisting { get; set; }

        public CreateBookingModel(ILoginService loginService, IBoatCatalog boatCatalog, IBookingCatalog bookingCatalog)
        {
            _loginService = loginService;
            _boatCatalog = boatCatalog;
            _bookingCatalog = bookingCatalog;
            EndIsAfterStart = true;
            PreExisting = null;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(int boatNum)
        {
            #region Validations
            EndIsAfterStart = true;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _bookingCatalog.Add(Booking);
            }
            catch (DateNotAfterDate)
            {
                EndIsAfterStart = false;
                return Page();
            }

            var bookings = (from b in _bookingCatalog.GetAllBookings()
                where b.BoatNum == boatNum
                where b.Journey.End.CompareTo(Booking.Journey.Start) < 0 //removes those that have ended before this begins
                where b.Journey.Start.CompareTo(Booking.Journey.End) > 0 //removes those that start after this ends
                select b).ToArray();

            if (bookings.Length != 0)
            {
                PreExisting = bookings[0].Journey;
                return Page();
            }
            #endregion

            Booking.BoatNum = boatNum;
            Booking.MemberId = _loginService.CurrentMember.Id;

            return RedirectToPage("/Boats/BoatIndex");
        }
    }
}
