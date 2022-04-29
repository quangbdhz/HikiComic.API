using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");

            builder.Property(x => x.FirstName).IsRequired(true).HasMaxLength(200);

            builder.Property(x => x.LastName).IsRequired(true).HasMaxLength(200);

            builder.Property(x => x.Dob).IsRequired(true);

            builder.Property(x => x.UrlImageUser).HasMaxLength(1000).IsUnicode(false);

            builder.Property(x => x.MoreInfo).HasMaxLength(1000).IsRequired(false);

            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired(true);

            builder.HasOne(x => x.Gender).WithMany(x => x.AppUsers).HasForeignKey(x => x.GenderId);
        }
    }
}
