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

            Boat.BoatNum = id;
            _boatCatalog.Update(Boat);
            return RedirectToPage("BoatIndex");
        }
    }
}
