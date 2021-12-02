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
        private List<IBlogPost> _blogPosts { get; }

        public BlogCatalog()
        {
            _blogPosts = new List<IBlogPost>();

            _blogPosts.Add(new Blog(){Id = 1, Title = "Reperation af joller", Content = "Skader på joller er blevet udbedret", Picture = "Billede af reparerede joller", Date = new DateTime(2021, 03, 12)});

        }


        public void AddBlogPost(IBlogPost blogPost)
        {
            _blogPosts.Add(blogPost);
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

        public List<IBlogPost> GetAllBlogPost()
        {
            return _blogPosts;
        }



    }
}
