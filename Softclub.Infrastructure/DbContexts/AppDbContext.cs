using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Softclub.Infrastructure.EntitiyConfigs;
using SoftclubTask.Domain.Entities;
namespace Softclub.Infrastructure.DbContexts;

public class AppDbContext : IdentityDbContext<Users>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<New> News { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<SoftclubTask.Domain.Entities.File> Files { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UserConfig());
        builder.ApplyConfiguration(new NewConfig());
        builder.ApplyConfiguration(new VideoConfig());
        builder.ApplyConfiguration(new CommentConfig());
        builder.ApplyConfiguration(new FileConfig());

        builder.Entity<IdentityUserLogin<string>>().HasNoKey();
        builder.Entity<IdentityUserRole<string>>().HasNoKey();
        builder.Entity<IdentityUserToken<string>>().HasNoKey();

    }
}
