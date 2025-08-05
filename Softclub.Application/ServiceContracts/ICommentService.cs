using SoftclubTask.Domain.Entities;

namespace Softclub.Application.ServiceContracts
{
    public interface ICommentService
    {
        IQueryable<Comment> GetNewsComments(int newId);
        Task CreateComment();
    }
}