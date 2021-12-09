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

        private Blog Blog { get; set; }

        public List<Blog> Blogs { get; private set; }


        public IndexModel()
        {
            Blogs = new BlogCatalog().GetAllBlogPost();
        }




        public void OnGet()
        {
            
        }
    }
}
