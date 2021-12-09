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
    public class CreateBoatModel : PageModel
    {
        private IBoatCatalog _boatCatalog;
        [BindProperty]
        public Boat Boat { get; set; }

        public CreateBoatModel(IBoatCatalog boatCatalog)
        {
            _boatCatalog = boatCatalog;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _boatCatalog.Add(Boat);
            return RedirectToPage("BoatIndex");
        }
    }
}
