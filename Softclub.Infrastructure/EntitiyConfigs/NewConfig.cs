using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftclubTask.Domain.Entities;

namespace Softclub.Infrastructure.EntitiyConfigs;

public class NewConfig : IEntityTypeConfiguration<New>
{
    public void Configure(EntityTypeBuilder<New> builder)
    {
        builder.Property(x => x.Title)
            .IsRequired();
    }
}
