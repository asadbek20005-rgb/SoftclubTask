using Softclub.Application.Models;
using SoftclubTask.Domain.Entities;

namespace Softclub.Application.ServiceContracts;

public interface INewService
{
    IQueryable<New> GetNews();
    Task CreateNew(CreateNewModel model);
    Task<New> GetNewById(int id);
    Task UpdateNew(UpdateNewModel model);
    IQueryable<New> Search(FilterNewModel model);

    Task AddNewToLikes(int newsId);
    Task GetLikedNew(int newsId);
    Task RemoveFromLikedNew(int newsId);

}