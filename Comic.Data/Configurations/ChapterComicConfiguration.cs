using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class ChapterComicConfiguration : IEntityTypeConfiguration<ChapterComic>
    {
        public void Configure(EntityTypeBuilder<ChapterComic> builder)
        {
            builder.ToTable("ChapterComics");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ComicId).IsRequired(true);

            builder.Property(x => x.NameChapter).HasMaxLength(100).IsRequired(true);

            builder.Property(x => x.DateCreated).IsRequired(true);

            builder.Property(x => x.ViewCount).IsRequired(true).HasDefaultValue(0);

            builder.Property(x => x.IsActive).IsRequired(true);

            builder.Property(x => x.SeoAlias).IsRequired(true).IsUnicode(false).HasMaxLength(300);
        }
    }
}
