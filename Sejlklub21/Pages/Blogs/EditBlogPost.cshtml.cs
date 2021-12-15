using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Blogs
{
    public class EditBlogPostModel : PageModel
    {
        private IBlogCatalog bloca;

        [BindProperty]
        public Blog Blog { get; set; }

        public EditBlogPostModel(IBlogCatalog catalog)
        {
            bloca = catalog;
        }


        public IActionResult OnGet(int id)
        {
            Blog = (Blog) bloca.GetBlogPost(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            bloca.UpdateBlogPost(Blog);
            return RedirectToPage("Index");
        }
    }
}
