using Comic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comic.Data.Configurations
{
    public class AuthorInDetailComicConfiguration : IEntityTypeConfiguration<AuthorInDetailComic>
    {
        public void Configure(EntityTypeBuilder<AuthorInDetailComic> builder)
        {
            builder.ToTable("AuthorInDetailComics");

            builder.HasKey(x => new { x.AuthorId, x.DetailComicId });

            builder.HasOne(x => x.Author).WithMany(x => x.AuthorInDetailComics).HasForeignKey(x => x.AuthorId);

            builder.HasOne(x => x.DetailComic).WithMany(x => x.AuthorInDetailComics).HasForeignKey(x => x.DetailComicId);
        }
    }
}
