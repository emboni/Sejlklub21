using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Boats
{
    public class EditBoatModel : PageModel
    {
        private IBoatCatalog _boatCatalog;
        private IBoat _boat;
        [BindProperty]
        public Boat Boat { get; set; }

        public EditBoatModel(IBoatCatalog boatCatalog)
        {
            _boatCatalog = boatCatalog;
        }

        public void OnGet(int id)
        {
            Boat = (Boat)_boatCatalog.GetBoat(id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _boat = (Boat)_boatCatalog.GetBoat(id);
            Boat.BoatNum = _boat.BoatNum;
            Boat.Damages = _boat.Damages;
            _boatCatalog.Update(Boat);
            return RedirectToPage("BoatIndex");
        }
    }
}
