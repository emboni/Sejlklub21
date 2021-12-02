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
    public class EditMemberModel : PageModel
    {
        private IMemberCatalog memberCatalog;
        private ILoginService loginService;

        [BindProperty]
        public Member Member { get; set; }

        public EditMemberModel(IMemberCatalog catalog, ILoginService service)
        {
            memberCatalog = catalog;
            loginService = service;
        }

        public IActionResult OnGet(int id)
        {
            if (!loginService.AdminPrivilege)
            {
                return RedirectToPage("/Logins/UnauthorizedAccess");
            }

            Member = memberCatalog.GetMember(id) as Member;

            return Page();
        }

        public IActionResult OnPost()
        {
            memberCatalog.UpdateMember(Member);

            return RedirectToPage("/Members/Index");
        }
    }
}