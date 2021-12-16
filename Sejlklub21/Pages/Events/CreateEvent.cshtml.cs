using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventCatalog eventCatalog;

        [BindProperty]
        public Event Event { get; set; }

        public CreateEventModel(IEventCatalog catalog) 
        {
            eventCatalog = catalog;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            eventCatalog.AddEvent(Event);

            return RedirectToPage("/Events/Index");
        }
    }
}
