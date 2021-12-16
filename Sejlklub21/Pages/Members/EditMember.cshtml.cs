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
        public IBoatTypeCatalog boatTypeCatalog;

        [BindProperty]
        public Member Member { get; set; }

        [BindProperty]
        public List<bool> AllowedBools { get; set; }

        private List<IBoatType> AllowedBoatTypes { get; set; }

        public EditMemberModel(IMemberCatalog catalog, ILoginService service, IBoatTypeCatalog typeCatalog)
        {
            memberCatalog = catalog;
            loginService = service;
            boatTypeCatalog = typeCatalog;

            AllowedBools = new List<bool>(new bool[boatTypeCatalog.GetAllTypes().Count]);
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
            for (int i = 0; i < AllowedBools.Count; i++)
            {
                if (AllowedBools[i] == true)
                {
                    AllowedBoatTypes.Add(boatTypeCatalog.GetType(i));
                }
            }

            Member.AllowedBoatTypes = AllowedBoatTypes;

            memberCatalog.UpdateMember(Member);

            return RedirectToPage("/Members/Index");
        }
    }
}