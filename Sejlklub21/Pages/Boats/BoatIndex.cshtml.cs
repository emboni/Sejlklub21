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
        private IBoatCatalog _boatCatalog;
        public List<IBoat> Boats { get; set; }

        public BoatIndexModel(IBoatCatalog boatCatalog)
        {
            Boats = boatCatalog.GetAllBoats();
            _boatCatalog = boatCatalog;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostDelete(int id)
        {
            _boatCatalog.Delete(id);
            return Redirect("BoatIndex");
        }
        
    }
}
