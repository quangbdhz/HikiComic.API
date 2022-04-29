using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class ComicStripConfiguration : IEntityTypeConfiguration<ComicStrip>
    {
        public void Configure(EntityTypeBuilder<ComicStrip> builder)
        {
            builder.ToTable("Comics");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.NameComic).IsRequired(true).HasMaxLength(200);

            builder.Property(x => x.DifferentNameComic).IsRequired(false).HasMaxLength(200);

            builder.Property(x => x.ViewCount).IsRequired(true).HasDefaultValue(0);

            builder.Property(x => x.DateCreated).IsRequired(true);

            builder.Property(x => x.UrlCoverImageComic).IsRequired(true).IsUnicode(false).HasMaxLength(300);

            builder.Property(x => x.IsActive).IsRequired(true);

            builder.Property(x => x.IdNewChapter).IsRequired(false);

        }
    }
}
