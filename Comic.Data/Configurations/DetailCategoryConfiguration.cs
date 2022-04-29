using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class DetailCategoryConfiguration : IEntityTypeConfiguration<DetailCategory>
    {
        public void Configure(EntityTypeBuilder<DetailCategory> builder)
        {
            builder.ToTable("DetailCategories");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.NameCategory).IsRequired(true).HasMaxLength(100);

            builder.Property(x => x.SeoDescription).IsRequired(false).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).IsRequired(false).HasMaxLength(150);

            builder.Property(x => x.SeoAlias).IsRequired(true).IsUnicode(false).HasMaxLength(100);

            builder.HasOne(x => x.Category).WithMany(x => x.DetailCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
