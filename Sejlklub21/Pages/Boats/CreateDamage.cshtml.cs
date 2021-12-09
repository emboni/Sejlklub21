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
    public class CreateDamageModel : PageModel
    {
        private IBoatCatalog _boatCatalog;

        [BindProperty]
        public Damage Damage { get; set; }

        public CreateDamageModel(IBoatCatalog boatCatalog)
        {
            _boatCatalog = boatCatalog;
        }

        public IActionResult OnPost(int boatNum)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            IBoat boat = _boatCatalog.GetBoat(boatNum);
            Damage = new Damage
            {
                Date = DateTime.Now,
                Status = DamageStatus.Status.IkkeBehandlet,
                Id = boat.Damages.Count == 0 ? 1 : boat.Damages.Max(x => x.Id) + 1
            };
            boat.Damages.Add(Damage);
            _boatCatalog.Update(boat);

            return RedirectToPage("Damages", new {id = boatNum});
        }
    }
}
