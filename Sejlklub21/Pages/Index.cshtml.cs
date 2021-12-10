using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IBookingCatalog _bookingCatalog;
        public List<IBooking> CurrentBookings { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IBookingCatalog bookingCatalog)
        {
            _logger = logger;
            _bookingCatalog = bookingCatalog;
        }

        public void OnGet()
        {
            CurrentBookings = (from b in _bookingCatalog.GetAllBookings()
                where b.Journey.Start.CompareTo(DateTime.Now) < 0
                where b.Completed == false
                select b).ToList();
        }

        public IActionResult OnPostComplete(int bookingId)
        {
            _bookingCatalog.MarkAsComplete(bookingId);
            OnGet();
            return Page();
        }
    }
}
