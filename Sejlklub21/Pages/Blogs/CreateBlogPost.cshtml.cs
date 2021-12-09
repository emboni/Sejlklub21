using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Blogs
{
    public class CreateBlogPostModel : PageModel
    {
        private BlogCatalog Bloca;

        [BindProperty]
        public Blog Blog { get; set; }

        public CreateBlogPostModel()
        {
            Bloca = new BlogCatalog();
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            Bloca.AddBlogPost(Blog);
            return RedirectToPage("Index");
        }
    }
}
