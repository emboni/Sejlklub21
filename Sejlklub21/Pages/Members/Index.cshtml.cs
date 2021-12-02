using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Members
{
    public class IndexModel : PageModel
    {
        private IMemberCatalog memberCatalog;
        private ILoginService loginService;

        public List<IMember> Members { get; set; }

        public IndexModel(IMemberCatalog catalog, ILoginService service)
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

            Members = memberCatalog.GetAllMembers();

            return Page();
        }

        public IActionResult OnPost()
        {
            Members = memberCatalog.GetAllMembers();

            return Page();
        }
    }
}