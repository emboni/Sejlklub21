using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
   public interface IBlogCatalog
   {

       void AddBlogPost(IBlogPost blogPost);
       void UpdateBlogPost(IBlogPost blogPost);
       void DeleteBlogPost(int Id);
       IBlogPost GetBlogPost(int id);
       List<IBlogPost> GetAllBlogPost();

   }
}
