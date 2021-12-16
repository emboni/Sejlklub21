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
            _blogPosts.Add(new Blog(){Id = 1, Title = "Reperation af joller",
                Date = new DateTime(2021, 03, 12), Content = "Vi fik repareret alle Joller", Picture = "Billede af repererede joller"});
            _blogPosts.Add(new Blog() {Id = 2, Title = "Junior Seljlads", Date = new DateTime(2021, 06, 20),
                Content = "Dagssejlads for juniorer", Picture = "Billede af Juniorsejlads"});
            _blogPosts.Add(new Blog() {Id = 3, Title = "Familiesejlads", Date = new DateTime(2021, 07, 10), Content = "Sejlads for familier",
                Picture = "Billede fra familie sejlads"});
        }



        public void AddBlogPost(IBlogPost blogPost)
        {
            List<int> blogIds = new List<int>();

            foreach (var bps in _blogPosts)
            {
                blogIds.Add(bps.Id);
            }

            if (blogIds.Count != 0)
            {
                int start = blogIds.Max();
                blogPost.Id = start + 1;
            }
            else
            {
                blogPost.Id = 1;
            }
            _blogPosts.Add(blogPost);
        }


        public void UpdateBlogPost(IBlogPost blogPost)
        {
            if (blogPost != null)
            {
                foreach (var post in GetAllBlogPost())
                {
                    if (post.Id == blogPost.Id)
                    {
                        post.Id = blogPost.Id;
                        post.Title = blogPost.Title;
                        post.Date = blogPost.Date;
                        post.Content = blogPost.Content;
                        post.Picture = blogPost.Picture;
                    }
                }
            }
        }

        public void DeleteBlogPost(int id)
        {
            foreach (var post in GetAllBlogPost())
            {
                if (post.Id == id)
                {
                    _blogPosts.Remove(post);
                }
            }
        }

        public IBlogPost GetBlogPost(int id)
        {
            foreach (var blogPost in GetAllBlogPost())
            {
                if (blogPost.Id == id)
                {
                    return blogPost;
                }
            }

            return new Blog();
        }

        public List<IBlogPost> GetAllBlogPost()
        {
            return _blogPosts.ToList();
        }




    }
}