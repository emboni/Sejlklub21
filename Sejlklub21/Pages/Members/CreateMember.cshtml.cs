using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Members
{
    public class CreateMemberModel : PageModel
    {
        private IMemberCatalog memberCatalog;
        private ILoginService loginService;

        public bool Error { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty]
        public Member Member { get; set; }

        public CreateMemberModel(IMemberCatalog catalog, ILoginService service)
        {
            memberCatalog = catalog;
            loginService = service;
        }

        public IActionResult OnGet()
        {
            if (!loginService.AdminPrivilege)
            {
                return RedirectToPage("/Logins/UnauthorizedAccess");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    memberCatalog.AddMember(Member);
                }
                catch (Exception e)
                {
                    Error = true;
                    ErrorMessage = e.Message;
                }

                return RedirectToPage("/Members/Index");
            }

            return Page();
        }
    }
}