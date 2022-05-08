using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class ListOfComicsUsersFollowConfiguration : IEntityTypeConfiguration<ListOfComicsUsersFollow>
    {
        public void Configure(EntityTypeBuilder<ListOfComicsUsersFollow> builder)
        {
            builder.ToTable("ListOfComicsUsersFollows");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.DateFollow).IsRequired(true);

            builder.HasOne(x => x.AppUser).WithMany(x => x.ListOfComicsUsersFollows).HasForeignKey(x => x.AppUserId);

            builder.HasOne(x => x.ComicStrip).WithMany(x => x.ListOfComicsUsersFollows).HasForeignKey(x => x.ComicId);
        }
    }
}
