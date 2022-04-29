using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class UrlImageComicConfiguration : IEntityTypeConfiguration<UrlImageComic>
    {
        public void Configure(EntityTypeBuilder<UrlImageComic> builder)
        {
            builder.ToTable("UrlImageComics");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.UrlImageChapterComic).IsUnicode(false).IsRequired(true).HasMaxLength(7800);

            builder.Property(x => x.IsActive).IsRequired(true);

            builder.HasOne(x => x.ChapterComic).WithMany(x => x.UrlImageComics).HasForeignKey(x => x.ChapterComicId);
        }
    }
}
