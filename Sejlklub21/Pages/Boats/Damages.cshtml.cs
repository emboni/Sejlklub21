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
    public class DamagesModel : PageModel
    {
        private IBoatCatalog _boatCatalog;
        public int BoatNumber { get; set; }
        public Boat Boat { get; set; }

        public DamagesModel(IBoatCatalog boatCatalog)
        {
            _boatCatalog = boatCatalog;
        }

        public void OnGet(int id)
        {
            BoatNumber = id;
            Boat = (Boat)_boatCatalog.GetBoat(id);
        }

        public IActionResult OnPostDelete(int id,int dmgId)
        {
            int dmgIndex = _boatCatalog.GetBoat(id).Damages.FindIndex(x => x.Id == dmgId);
            Boat = (Boat) _boatCatalog.GetBoat(id);
            Boat.Damages.RemoveAt(dmgIndex);
            _boatCatalog.Update(Boat);
            return RedirectToPage("/Boats/Damages", new {id = id});
        }
    }
}
