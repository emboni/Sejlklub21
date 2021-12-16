using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IEventCatalog EventCatalog;
        
        public List<IEvent> EventsList { get; private set; }

        //public IndexModel(IEventCatalog eventCatalog) //Nu får jeg injectet mit eventCatalog - får adgang til eventCatalog
        //{
        //    EventsList = eventCatalog.GetAllEvents(); //så får jeg fat i alle eventsene
        //}

        public IndexModel(IEventCatalog catalog)
        {
            EventCatalog = catalog;
        }
        public void OnGet()
        {
            EventsList = EventCatalog.GetAllEvents();
        }
    }
}
