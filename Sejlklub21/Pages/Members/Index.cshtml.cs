using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using Sejlklub21.Services;

namespace Sejlklub21.Pages.Members
{
    public class IndexModel : PageModel
    {
        private IMemberCatalog memberCatalog;

        public List<IMember> Members { get; set; }

        public IndexModel(IMemberCatalog catalog)
        {
            memberCatalog = catalog;
        }

        public void OnGet()
        {
            Members = memberCatalog.GetAllMembers();
        }

        public void OnPost()
        {
            Members = memberCatalog.GetAllMembers();
        }
    }
}