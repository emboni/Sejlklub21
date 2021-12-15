using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Pages.Blogs
{
    public class DeleteBlogPostModel : PageModel
    {
        private IBlogCatalog bloca;

        [BindProperty]
        public Blog Blog { get; set; }

        public DeleteBlogPostModel(IBlogCatalog catalog)
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
            bloca.DeleteBlogPost(Blog.Id);
            return RedirectToPage("Index");
        }
    }
}
