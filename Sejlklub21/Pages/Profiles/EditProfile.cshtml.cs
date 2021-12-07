using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Logins
{
    public class EditProfileModel : PageModel
    {
        private IMemberCatalog memberCatalog;
        private ILoginService loginService;
        private IHostingEnvironment hostingEnvironment;

        [BindProperty]
        public Member Member { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        public EditProfileModel(IMemberCatalog catalog, ILoginService service, IHostingEnvironment environment)
        {
            memberCatalog = catalog;
            loginService = service;
            hostingEnvironment = environment;
        }

        public IActionResult OnGet(int id)
        {
            if (loginService.CheckCurrentMember() == false)
            {
                return RedirectToPage("/Logins/UnauthorizedAccess");
            }

            Member = memberCatalog.GetMember(id) as Member;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            string file = Path.Combine(hostingEnvironment.ContentRootPath, "uploads", Upload.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }

            memberCatalog.UpdateMember(Member);

            return RedirectToPage("/Profiles/Profile");
        }
    }
}