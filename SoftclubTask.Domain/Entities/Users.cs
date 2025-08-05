using Microsoft.AspNetCore.Identity;

namespace SoftclubTask.Domain.Entities;
public class Users : IdentityUser
{
    public string? AboutMe { get; set; }

    public ICollection<New> News { get; set; }
}
