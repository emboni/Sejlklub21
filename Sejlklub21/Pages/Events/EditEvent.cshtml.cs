using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Events
{
    public class EditEventModel : PageModel
    {
        private IEventCatalog eventCatalog;
        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel(IEventCatalog catalog)
        {
            eventCatalog = catalog;
        }

        public IActionResult OnGet(int id)
        {
            Event = (Event) eventCatalog.GetEvent(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            eventCatalog.UpdateEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
