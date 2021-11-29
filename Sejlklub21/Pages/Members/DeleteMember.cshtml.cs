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
    public class DeleteMemberModel : PageModel
    {
        private IMemberCatalog memberCatalog;

        [BindProperty]
        public IMember Member { get; set; }

        public DeleteMemberModel(IMemberCatalog catalog)
        {
            memberCatalog = catalog;
        }

        public IActionResult OnGet(int id)
        {
            Member = memberCatalog.GetMember(id);

            return Page();
        }

        public IActionResult OnPost()
        {
            memberCatalog.DeleteMember(Member);

            return RedirectToPage("/Members/Index");
        }
    }
}