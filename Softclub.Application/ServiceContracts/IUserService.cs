using Softclub.Application.Models;
using SoftclubTask.Domain.Entities;

namespace Softclub.Application.ServiceContracts
{
    public interface IUserService
    {
        IQueryable<Users> GetAllUsers();
        Task Register(Register model);
        Task Login(LoginModel model);
        Task<Users> Update(Guid userId, UpdateUserModel model);
        Task Delete(Guid userId);
    }
}
