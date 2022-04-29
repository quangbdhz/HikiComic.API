using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.NameAuthor).IsRequired(true).HasMaxLength(150);

            builder.Property(x => x.DifferentName).IsRequired(false).HasMaxLength(150);

            builder.Property(x => x.DateCreated).IsRequired(true);

            builder.Property(x => x.IsActive).IsRequired(true);

            builder.Property(x => x.SeoAlias).IsRequired(true).IsUnicode(false);

        }

    }
}
