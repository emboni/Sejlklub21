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
    public class IndexModel : PageModel
    {

        private IBlogCatalog Blo;

        public List<Blog> Blogs { get; private set; }




        public void OnGet()
        {
        }
    }
}
