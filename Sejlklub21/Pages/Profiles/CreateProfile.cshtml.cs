using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Profiles
{
    public class CreateProfileModel : PageModel
    {
        private IMemberCatalog memberCatalog;
        private ILoginService loginService;

        [BindProperty]
        public Member Member { get; set; }

        public CreateProfileModel(IMemberCatalog catalog, ILoginService service)
        {
            memberCatalog = catalog;
            loginService = service;
        }

        public IActionResult OnGet()
        {
            if (loginService.CheckCurrentMember() == false)
            {
                return RedirectToPage("/Logins/UnauthorizedAccess");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                memberCatalog.AddMember(Member);

                return RedirectToPage("/Profiles/Profile");
            }

            return Page();
        }
    }
}