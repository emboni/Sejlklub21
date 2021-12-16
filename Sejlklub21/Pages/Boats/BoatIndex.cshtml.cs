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
    public class BoatIndexModel : PageModel
    {
        private IBoatCatalog _boatCatalog;
        public List<IBoat> Boats { get; set; }
        public ILoginService LoginService { get; set; }

        public BoatIndexModel(IBoatCatalog boatCatalog, ILoginService loginService)
        {
            Boats = boatCatalog.GetAllBoats();
            LoginService = loginService;
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
