using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Accounts
{
    public class LoginModel : PageModel
    {
        private IMemberCatalog memberCatalog;
        private ILoginService loginService;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IMember LoginMember { get; set; }

        public LoginModel(IMemberCatalog catalog, ILoginService service)
        {
            memberCatalog = catalog;
            loginService = service;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                LoginMember = memberCatalog.Login(Username, Password);

                if (LoginMember != null)
                {
                    loginService.CurrentMember = LoginMember;

                    if (LoginMember.Admin)
                    {
                        return RedirectToPage("/Members/Index");
                    }
                    else if (!LoginMember.Admin)
                    {
                        return RedirectToPage("/Index");
                    }
                }
            }

            return Page();
        }
    }
}