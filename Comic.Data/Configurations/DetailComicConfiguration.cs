using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class DetailComicConfiguration : IEntityTypeConfiguration<DetailComic>
    {
        public void Configure(EntityTypeBuilder<DetailComic> builder)
        {
            builder.ToTable("DetailComics");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Rating).IsRequired(true).HasDefaultValue(0);

            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(3800);

            builder.Property(x => x.SeoDescription).IsRequired(false).HasMaxLength(1000);

            builder.Property(x => x.SeoTitle).IsRequired(false).HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired(true).HasMaxLength(200).IsUnicode(false);

            builder.HasOne(x => x.ComicStrip).WithMany(x => x.DetailComics).HasForeignKey(x => x.ComicId);

            builder.HasOne(x => x.Status).WithMany(x => x.DetailComics).HasForeignKey(x => x.StatusId);
        }
    }
}
