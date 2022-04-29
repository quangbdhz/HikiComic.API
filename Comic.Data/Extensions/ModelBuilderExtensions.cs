using Comic.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Comic.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status() { Id = 1, NameStatus = "Còn sử dụng" },
                new Status() { Id = 2, NameStatus = "Hết sử dụng" });

            modelBuilder.Entity<Gender>().HasData(
                new Gender() { Id = 1, NameGender = "Male" },
                new Gender() { Id = 2, NameGender = "Female" }
                );

            var adminRoleId = new Guid("E1DB1200-1BB6-4156-9DA3-135E91D94ABA");
            var staffRoleId = new Guid("C489F858-AABD-4264-96C1-5CDCA251D871");
            var customerRoleId = new Guid("2F0C7B75-8934-4101-BEF2-C850E42D21DE");

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole() { Id = adminRoleId, Name = "admin", NormalizedName = "admin", Description = "Administrator role" },
                new AppRole() { Id = staffRoleId, Name = "staff", NormalizedName = "staff", Description = "Staff role" },
                new AppRole() { Id = customerRoleId, Name = "customer", NormalizedName = "customer", Description = "Customer role" });

            var adminId = new Guid("0B64F6F0-9F60-45C9-9E7B-F68CCC3FC57F");

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "tranquangbhdz@gmail.com",
                    NormalizedEmail = "tranquangbhdz@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                    SecurityStamp = string.Empty,
                    FirstName = "Tran",
                    LastName = "Quang",
                    Dob = new DateTime(2001, 10, 08),
                    UrlImageUser = "https://64.media.tumblr.com/f3685609f6f9e0f15b70b740380fe0db/85dff69cc547be63-1d/s640x960/a0fa84e4ec96b338ec45f925baccc9619131013c.jpg",
                    MoreInfo = "Chùm",
                    IsActive = true,
                    GenderId = 1
                });

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 2, IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 3, IsShowHome = true, IsActive = true, DateCreated = DateTime.Now });

            modelBuilder.Entity<DetailCategory>().HasData(
                new DetailCategory() { Id = 1, CategoryId = 1, NameCategory = "Action", SeoAlias = "action", SeoDescription = "Thể loại hành động", SeoTitle = "Hành Động" },
                new DetailCategory() { Id = 2, CategoryId = 2, NameCategory = "Slice of Life", SeoAlias = "slice-of-life", SeoDescription = "Thể loại nói về cuộc sống đời thường", SeoTitle = "Cuộc Sống Đời Thường" }, 
                new DetailCategory() { Id = 3, CategoryId = 3, NameCategory = "Harem", SeoAlias = "harem", SeoDescription = "Thể loại truyện tình cảm, lãng mạn mà trong đó, nhiều nhân vật nữ thích một nam nhân vật chính", SeoTitle = "Tình Cảm, Lãng Mạn, Nhiều Nữ Thích Một Nam" });;

            modelBuilder.Entity<Author>().HasData(
                new Author() { Id = 1, DateCreated = DateTime.Now, NameAuthor = "Đường Gia Tam Thiếu", DifferentName = "Trương Uy", IsActive = true, SeoAlias = "duong-gia-tam-thieu" },
                new Author() { Id = 2, DateCreated = DateTime.Now, NameAuthor = "Thiên Tằm Thổ Đậu", DifferentName = "Lý Hổ", IsActive = true, SeoAlias = "thien-tam-tho-dau" });

            modelBuilder.Entity<ComicStrip>().HasData(
                new ComicStrip() { Id = 1, DateCreated = DateTime.Now, NameComic = "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", DifferentNameComic = "", ViewCount = 0, IsActive = true, IdNewChapter = null, UrlCoverImageComic = "https://static.cdnno.com/poster/dau-la-dai-luc-trung-sinh-duong-tam/300.jpg?1621052117" },
                new ComicStrip() { Id = 2, DateCreated = DateTime.Now, NameComic = "Đấu Phá Thương Khung", DifferentNameComic = "", ViewCount = 0, IsActive = true, IdNewChapter = null, UrlCoverImageComic = "https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png" });

            modelBuilder.Entity<DetailComic>().HasData(
                new DetailComic() { Id = 1, ComicId = 1, StatusId = 1, Rating = 0, Description = "Một đời Thần Vương trùng sinh tại Pháp Lam thế giới thần kỳ, hắn kinh ngạc phát hiện, nơi này hết thảy đều là như vậy kỳ diệu, hắn càng là vận khí tuyệt hảo tìm được thê tử chuyển thế thân. Thế nhưng là, nàng không có trí nhớ của kiếp trước, gặp nhau lần nữa đã là người qua đường.", SeoDescription = "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam Một Phần Mới Của Tác Giả Đường Gia Tam Thiếu", SeoTitle = "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", SeoAlias = "dau-la-dai-luc-trung-sinh-duong-tam-119313" },
                new DetailComic() { Id = 2, ComicId = 2, StatusId = 1, Rating = 0, Description = "Đây là một thế giới thuộc về Đấu Khí, không hề có ma pháp hoa tiếu diễm lệ, chỉ có đấu khí cương mãnh phồn thịnh ! Tưởng tượng thế giới đó sẽ phát triển ra sao ? mời các bạn xem Đấu Phá Thương Khung!", SeoDescription = "Đấu Phá Thương Khung Một Trong Những Bộ Truyện Có Lượt Xem Nhiều Nhất", SeoTitle = "Đấu Phá Thương Khung", SeoAlias = "dau-pha-thuong-khung-123813" });

            modelBuilder.Entity<CategoryInDetailComic>().HasData(
                new CategoryInDetailComic() { CategoryId = 1, DetailComicId = 1 },
                new CategoryInDetailComic() { CategoryId = 1, DetailComicId = 2 },
                new CategoryInDetailComic() { CategoryId = 3, DetailComicId = 2 });

            modelBuilder.Entity<AuthorInDetailComic>().HasData(
                new AuthorInDetailComic() { AuthorId = 1, DetailComicId = 1 },
                new AuthorInDetailComic() { AuthorId = 2, DetailComicId = 2 });




        }
    }
}
