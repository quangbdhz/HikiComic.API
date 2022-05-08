using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class HistoryReadComicOfUserConfiguration : IEntityTypeConfiguration<HistoryReadComicOfUser>
    {
        public void Configure(EntityTypeBuilder<HistoryReadComicOfUser> builder)
        {
            builder.ToTable("HistoryReadComicOfUsers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.DateRead).IsRequired(true);

            builder.HasOne(x => x.AppUser).WithMany(x => x.HistoryReadComicOfUsers).HasForeignKey(x => x.AppUserId);

            builder.HasOne(x => x.ComicStrip).WithMany(x => x.HistoryReadComicOfUsers).HasForeignKey(x => x.ComicId);

            builder.HasOne(x => x.ChapterComic).WithMany(x => x.HistoryReadComicOfUsers).HasForeignKey(x => x.ChapterId);

        }
    }
}
