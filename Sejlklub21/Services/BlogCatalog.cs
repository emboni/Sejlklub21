using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Services
{
    public class BlogCatalog : IBlogCatalog
    {
        private List<Blog> _blogPosts { get; }

        public BlogCatalog()
        {
            _blogPosts = new List<Blog>();
            _blogPosts.Add(new Blog(){Id = 1, Title = "Reperation af joller",
                Date = new DateTime(2021, 03, 12), Content = "Vi fik repareret alle Joller", Picture = "Billede af repererede joller"});
            _blogPosts.Add(new Blog() {Id = 2, Title = "Junior Seljlads", Date = new DateTime(2021, 06, 20),
                Content = "Dagssejlads for juniorer", Picture = "Billede af Juniorsejlads"});
            _blogPosts.Add(new Blog() {Id = 3, Title = "Familiesejlads", Date = new DateTime(2021, 07, 10), Content = "Sejlads for familier",
                Picture = "Billede fra familie sejlads"});
        }


        public void AddBlogPost(Blog bp)
        {
            List<int> BlogIds = new List<int>();

            foreach (var bps in _blogPosts)
            {
                BlogIds.Add(bps.Id);
            }

            if (BlogIds.Count != 0)
            {
                int start = BlogIds.Max();
                bp.Id = start + 1;
            }
            else
            {
                bp.Id = 1;
            }
            _blogPosts.Add(bp);
        }

        public void AddBlogPost(IBlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlogPost(IBlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlogPost(int Id)
        {
            throw new NotImplementedException();
        }

        public IBlogPost GetBlogPost(int id)
        {
            throw new NotImplementedException();
        }

        List<IBlogPost> IBlogCatalog.GetAllBlogPost()
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogPost()
        {
            return _blogPosts.ToList();
        }



    }
}
