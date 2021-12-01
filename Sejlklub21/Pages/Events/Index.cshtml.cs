using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Pages.Events
{
    public class IndexModel : PageModel
    {
        public List<IEvent> EventsList { get; set; }

        public IndexModel(IEventCatalog eventCatalog) //Nu får jeg injectet mit eventCatalog - får adgang til eventCatalog
        {
            EventsList = eventCatalog.GetAllEvents(); //så får jeg fat i alle eventsene
        }
        public void OnGet()
        {


        }
    }
}
