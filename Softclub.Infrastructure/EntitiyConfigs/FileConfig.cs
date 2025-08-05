using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = SoftclubTask.Domain.Entities.File;

namespace Softclub.Infrastructure.EntitiyConfigs
{
    public class FileConfig : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.Property(e => e.FileSize)
           .HasMaxLength(100 * 1024 * 1024);
        }
    }
}
