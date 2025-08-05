using Microsoft.AspNetCore.Http;

namespace Softclub.Application.Models
{
    public class UploadVideoModel
    {
        public IFormFile file { get; set; }
    }
}
