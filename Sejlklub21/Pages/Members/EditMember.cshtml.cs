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

        [BindProperty]
        public Member Member { get; set; }

        public EditMemberModel(IMemberCatalog catalog)
        {
            memberCatalog = catalog;
        }

        public IActionResult OnGet(int id)
        {
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