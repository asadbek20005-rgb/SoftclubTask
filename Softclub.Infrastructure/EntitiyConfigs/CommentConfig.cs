using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftclubTask.Domain.Entities;

namespace Softclub.Infrastructure.EntitiyConfigs;

public class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(x => x.Text)
            .HasMaxLength(5000);
    }
}
