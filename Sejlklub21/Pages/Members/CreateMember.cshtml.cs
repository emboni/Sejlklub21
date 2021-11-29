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

        [BindProperty]
        public IMember Member { get; set; }

        public CreateMemberModel(IMemberCatalog catalog)
        {
            memberCatalog = catalog;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            memberCatalog.AddMember(Member);

            return RedirectToPage("/Members/Index");
        }
    }
}