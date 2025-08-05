using System.ComponentModel.DataAnnotations;

namespace SoftclubTask.Domain.Entities;

public class Video
{
    public int Id { get; set; }
    [MinLength(5)]
    public string Title { get; set; }
    public string Description { get; set; }
    public string FileUrl { get; set; }
    public string VideoType { get; set; }

    public bool IsLiked { get; set; } = false;

}
