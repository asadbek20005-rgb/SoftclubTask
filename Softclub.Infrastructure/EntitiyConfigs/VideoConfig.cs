using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftclubTask.Domain.Entities;

namespace Softclub.Infrastructure.EntitiyConfigs
{
    public class VideoConfig : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.Property(x => x.Description)
                .HasMaxLength(200);
            builder.Property(x => x.VideoType)
                .IsRequired();
        }
    }
}
