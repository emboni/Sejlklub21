using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Pages.Bookings
{
    public class MyBookingsModel : PageModel
    {
        private IBookingCatalog _bookingCatalog;
        private ILoginService _loginService;
        private IBoatCatalog _boatCatalog;

        public IMember CurrentMember { get; set; }
        public List<IBooking> Bookings { get; set; }
        public IBoatCatalog BoatCatalog { get; set; }

        public MyBookingsModel(IBookingCatalog bookingCatalog, ILoginService loginService, IBoatCatalog boatCatalog)
        {
            _bookingCatalog = bookingCatalog;
            _loginService = loginService;
            _boatCatalog = boatCatalog;
        }
        public IActionResult OnGet()
        {
            if (!_loginService.CheckCurrentMember())
            {
                return RedirectToPage("/index");
            }

            CurrentMember = _loginService.CurrentMember;
            BoatCatalog = _boatCatalog;
            Bookings =
                (from b in _bookingCatalog.GetAllBookings()
                    where b.MemberId == CurrentMember.Id
                    select b).ToList();
            return Page();
        }

        public IActionResult OnPostDelete(int bookingId)
        {
            _bookingCatalog.Delete(bookingId);
            return RedirectToPage("/Bookings/MyBookings");
        }
    }
}
