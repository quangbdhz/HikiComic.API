using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ParentId).IsRequired(false);

            builder.Property(x => x.DateCreated).IsRequired(true);

            builder.Property(x => x.IsActive).IsRequired(true);

            builder.Property(x => x.IsShowHome).IsRequired(true);

            builder.Property(x => x.UrlImageCategory).IsRequired(true).HasMaxLength(300).IsUnicode(false);
        }
    }
}
