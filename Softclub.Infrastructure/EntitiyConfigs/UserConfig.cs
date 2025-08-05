using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftclubTask.Domain.Entities;

namespace Softclub.Infrastructure.EntitiyConfigs;

public class UserConfig : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.Property(x => x.AboutMe)
            .HasMaxLength(50);

        builder.Property(x => x.Email)
            .IsRequired();

        builder.Property(x => x.UserName)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasIndex(x => x.UserName).IsUnique();

       
    }
}
