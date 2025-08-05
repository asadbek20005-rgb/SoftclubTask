using System.ComponentModel.DataAnnotations;

namespace SoftclubTask.Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    [MinLength(20)]
    public string Text { get; set; }

    public bool IsLiked { get; set; } = false;


    public int NewId { get; set; }
    public New New { get; set; }


    public int CommentId { get; set; }
    public Comment comment { get; set; }
}
