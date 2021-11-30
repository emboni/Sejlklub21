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

        private LoginService loginService;

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginModel(IMemberCatalog catalog, LoginService service)
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
                if (memberCatalog.Login(Username, Password))
                {
                    loginService.CurrentMember = Member;

                    if (Member.Admin)
                    {
                        return RedirectToPage("/Index");
                    }
                    else if (!Member.Admin)
                    {
                        return RedirectToPage("/Members/Index");
                    }
                }
            }

            return Page();
        }
    }
}