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

        [BindProperty]
        public Damage Damage { get; set; }
        public DamageStatus.Status DmgStatus { get; set; }

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
            IBoat boat = _boatCatalog.GetBoat(boatId);
            Damage dmg = boat.Damages.First(x => x.Id == dmgId);

            boat.Damages[boat.Damages.IndexOf(dmg)] = Damage;

            _boatCatalog.Update(boat);
            
            return RedirectToPage("/Boats/Damages", new { id = boatId });
        }
    }
}
