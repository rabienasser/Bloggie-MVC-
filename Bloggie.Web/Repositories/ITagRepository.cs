using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllTags();
        Task<Tag?> GetSingleTag(Guid id);
        Task<Tag> AddTag(Tag tag);
        Task<Tag?> UpdateTag(Tag tag);
        Task<Tag?> DeleteTag(Guid id);
    }
}
