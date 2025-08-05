using System.ComponentModel.DataAnnotations;

namespace SoftclubTask.Domain.Entities;

public class New
{
    public int Id { get; set; }
    [MinLength(10)]
    public string Title { get; set; }
    [MinLength(100)]
    public string Content { get; set; }

    public bool IsLiked { get; set; } = false;
    public ICollection<Comment> Comments { get; set; }  
}
