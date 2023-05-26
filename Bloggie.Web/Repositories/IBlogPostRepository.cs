using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface IBlogPostRepository
    {
        
        Task<BlogPost> AddBlogPost(BlogPost blogPost);
        Task<IEnumerable<BlogPost>> GetAllBlogPosts();
        Task<BlogPost?> GetSingleBlogPost(Guid id);
        Task<BlogPost?> UpdateBlogPost(BlogPost blogPost);
        Task<BlogPost?> DeleteBlogPost(Guid id);

    }
}
