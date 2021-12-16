using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Blogs
{
    public class CreateBlogPostModel : PageModel
    {
        //private BlogCatalog Bloca;
        private IBlogCatalog Bloca;

        [BindProperty]
        public Blog Blog { get; set; }

        public CreateBlogPostModel(IBlogCatalog catalog)
        {
            //Bloca = BlogCatalog.Instance;
            Bloca = catalog;
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
            Bloca.AddBlogPost(Blog);
            return RedirectToPage("Index");
        }
    }
}
