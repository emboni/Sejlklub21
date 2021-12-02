using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Pages.Accounts
{
    public class LogoutModel : PageModel
    {
        private ILoginService loginService;

        public IMember CurrentMember { get; set; }

        public LogoutModel(ILoginService service)
        {
            loginService = service;

            CurrentMember = loginService.CurrentMember;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            loginService.SetCurrentMember(null);

            return RedirectToPage("/Index");
        }
    }
}