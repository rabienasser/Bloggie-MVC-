using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BloggieDbContext _bloggieDbContext;

        public BlogPostRepository(BloggieDbContext bloggieDbContext)
        {
            _bloggieDbContext = bloggieDbContext;
        }

        public async Task<BlogPost> AddBlogPost(BlogPost blogPost)
        {
            await _bloggieDbContext.BlogPosts.AddAsync(blogPost);
            await _bloggieDbContext.SaveChangesAsync();
            return blogPost;
        }

        public Task<BlogPost?> DeleteBlogPost(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost?> GetSingleBlogPost(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost?> UpdateBlogPost(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
