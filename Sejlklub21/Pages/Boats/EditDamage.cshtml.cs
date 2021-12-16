using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Boats
{
    public class EditDamageModel : PageModel
    {
        private IBoatCatalog _boatCatalog;
        private Damage _damage;

        [BindProperty]
        public Damage Damage { get; set; }

        public EditDamageModel(IBoatCatalog boatCatalog)
        {
            _boatCatalog = boatCatalog;
        }
        public void OnGet(int boatId, int dmgId)
        {
            Damage = (Damage)_boatCatalog.GetBoat(boatId).GetDamage(dmgId);
        }

        public IActionResult OnPost(int boatId, int dmgId)
        {
            _damage = (Damage)_boatCatalog.GetBoat(boatId).GetDamage(dmgId);
            IBoat boat = _boatCatalog.GetBoat(boatId);

            Damage.Id = _damage.Id;
            Damage.Date = _damage.Date;

            boat.Damages[boat.Damages.FindIndex(x=>x.Id == dmgId)] = Damage;

            _boatCatalog.Update(boat);
            
            return RedirectToPage("/Boats/Damages", new { id = boatId });
        }
    }
}
