using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Services
{
    public class BlogCatalog : IBlogCatalog
    {
        private List<IBlogPost> _blogPost;

        public BlogCatalog()
        {
            _blogPost = new List<IBlogPost>();
        }

        public void AddBlogPost(IBlogPost blogPost)
        {
            _blogPost.Add(blogPost);
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
            throw new NotImplementedException();
        }
    }
}
