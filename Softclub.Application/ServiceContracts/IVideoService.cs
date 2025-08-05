using Softclub.Application.Models;
using SoftclubTask.Domain.Entities;

namespace Softclub.Application.ServiceContracts
{
    public interface IVideoService
    {
        IQueryable<Video> GetVideos();
        Task UploadVideo(UploadVideoModel model);
        Task DownloadVideo(DownloadVdeoModel model);
        Task DeleteVideo(int id);


        Task AddVideoToLikes(int id);
        Task GetLikedVideo(int id);
        Task RemoveFromLikedVideo(int id);
    }
}
