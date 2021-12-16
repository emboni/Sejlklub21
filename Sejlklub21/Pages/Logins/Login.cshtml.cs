using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private ILoginService loginService;

        public bool Error { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        public IMember LoginMember { get; set; }

        public LoginModel(IMemberCatalog catalog, ILoginService service)
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
                try
                {
                    LoginMember = memberCatalog.Login(Email, Password);

                    if (LoginMember != null)
                    {
                        loginService.SetCurrentMember(LoginMember);

                        if (loginService.AdminPrivilege)
                        {
                            return RedirectToPage("/Members/Index");
                        }
                        else if (!loginService.AdminPrivilege)
                        {
                            return RedirectToPage("/Index");
                        }
                    }
                }
                catch (Exception e)
                {
                    Error = true;
                    ErrorMessage = e.Message;
                }
            }

            return Page();
        }
    }
}