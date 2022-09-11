using Post.Query.Domain.Entities;

namespace Post.Query.Domain.Repositories
{
    public interface ICommentRepository
    {
        Task CreateAsync(CommentEntity comment);
        Task<CommentEntity> GetByIdAsync(Guid commentId);
        Task UpdateAsync(CommentEntity comment);
        Task DeleteAsync(Guid commentId);
    }
}