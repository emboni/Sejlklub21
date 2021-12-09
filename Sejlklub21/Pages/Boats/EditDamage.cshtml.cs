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
    public class EditDamageModel : PageModel
    {
        private IBoatCatalog _boatCatalog;

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
    }
}
