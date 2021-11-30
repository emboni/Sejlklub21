using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Pages.Boats
{
    public class BoatIndexModel : PageModel
    {
        public List<IBoat> Boats { get; set; }

        public BoatIndexModel(IBoatCatalog boatCatalog)
        {
            Boats = boatCatalog.GetAllBoats();

        }

        public void OnGet()
        {
        }
    }
}
