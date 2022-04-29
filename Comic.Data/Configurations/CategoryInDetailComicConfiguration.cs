using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class CategoryInDetailComicConfiguration : IEntityTypeConfiguration<CategoryInDetailComic>
    {
        public void Configure(EntityTypeBuilder<CategoryInDetailComic> builder)
        {
            builder.ToTable("CategoryInDetailComics");

            builder.HasKey(x => new { x.CategoryId, x.DetailComicId });

            builder.HasOne(x => x.Category).WithMany(x => x.CategoryInDetailComics).HasForeignKey(x => x.CategoryId);

            builder.HasOne(x => x.DetailComic).WithMany(x => x.CategoryInDetailComics).HasForeignKey(x => x.DetailComicId);
        }
    }
}
