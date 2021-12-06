using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Logins
{
    public class ProfileModel : PageModel
    {
        private ILoginService loginService;

        [BindProperty]
        public IMember CurrentMember { get; set; }

        public ProfileModel(ILoginService service)
        {
            loginService = service;
        }

        public IActionResult OnGet()
        {
            if (loginService.CheckCurrentMember() == false)
            {
                return RedirectToPage("/Logins/UnauthorizedAccess");
            }

            CurrentMember = loginService.CurrentMember;

            return Page();
        }
    }
}