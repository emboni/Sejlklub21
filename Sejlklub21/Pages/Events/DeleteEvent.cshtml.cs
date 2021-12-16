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
    public class DeleteEventModel : PageModel
    {
        private IEventCatalog eventCatalog;
        [BindProperty] 
        public Event Event { get; set; }

        public DeleteEventModel(IEventCatalog catalog)
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
            eventCatalog.DeleteEvent(Event.Id);
            return RedirectToPage("Index");
        }
    }
}



