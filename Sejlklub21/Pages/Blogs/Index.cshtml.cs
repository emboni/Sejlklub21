using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Blogs
{
    public class IndexModel : PageModel
    {
        private IBlogCatalog _bloca;

        public List<IBlogPost> Blogs { get; private set; }


        public IndexModel(IBlogCatalog catalog)
        {
            _bloca = catalog;
        }




        public void OnGet()
        {
            Blogs = _bloca.GetAllBlogPost();
        }
    }
}
