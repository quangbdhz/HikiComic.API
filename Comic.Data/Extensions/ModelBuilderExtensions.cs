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
                new Status() { Id = 1, NameStatus = "Đang tiến hành" },
                new Status() { Id = 2, NameStatus = "Hoàn thành" });

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
                new Category() { Id = 1, UrlImageCategory = "https://inkr.com/images/explore/action.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 2, UrlImageCategory = "https://inkr.com/images/explore/comedy.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 3, UrlImageCategory = "https://inkr.com/images/explore/comedy.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 4, UrlImageCategory = "https://inkr.com/images/explore/adventure.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 5, UrlImageCategory = "https://inkr.com/images/explore/romance.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 6, UrlImageCategory = "https://inkr.com/images/explore/horror.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 7, UrlImageCategory = "https://inkr.com/images/explore/mature.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 8, UrlImageCategory = "https://inkr.com/images/explore/comedy.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 9, UrlImageCategory = "https://inkr.com/images/explore/manhua.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 10, UrlImageCategory = "https://inkr.com/images/explore/comedy.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 11, UrlImageCategory = "https://inkr.com/images/explore/comedy.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now },
                new Category() { Id = 12, UrlImageCategory = "https://inkr.com/images/explore/comedy.svg", IsShowHome = true, IsActive = true, DateCreated = DateTime.Now });

            modelBuilder.Entity<DetailCategory>().HasData(
                new DetailCategory() { Id = 1, CategoryId = 1, NameCategory = "Action", SeoAlias = "/action", SeoDescription = "Thể loại hành động", SeoTitle = "Hành Động" },
                new DetailCategory() { Id = 2, CategoryId = 2, NameCategory = "Slice of Life", SeoAlias = "/slice-of-life", SeoDescription = "Thể loại nói về cuộc sống đời thường", SeoTitle = "Cuộc Sống Đời Thường" },
                new DetailCategory() { Id = 3, CategoryId = 3, NameCategory = "Harem", SeoAlias = "/harem", SeoDescription = "Thể loại truyện tình cảm, lãng mạn mà trong đó, nhiều nhân vật nữ thích một nam nhân vật chính", SeoTitle = "Tình Cảm, Lãng Mạn, Nhiều Nữ Thích Một Nam" },
                new DetailCategory() { Id = 4, CategoryId = 4, NameCategory = "Adventure", SeoAlias = "/adventure", SeoDescription = "Thể loại phiêu lưu, mạo hiểm, thường là hành trình của các nhân vật" },
                new DetailCategory() { Id = 5, CategoryId = 5, NameCategory = "Romance", SeoAlias = "/romance", SeoDescription = "Thường là những câu chuyện về tình yêu, tình cảm lãng mạn. Ớ đây chúng ta sẽ lấy ví dụ như tình yêu giữa một người con trai và con gái, bên cạnh đó đặc điểm thể loại này là kích thích trí tưởng tượng của bạn về tình yêu" },
                new DetailCategory() { Id = 6, CategoryId = 6, NameCategory = "Horror", SeoAlias = "/horror", SeoDescription = "Horror là: rùng rợn, nghe cái tên là bạn đã hiểu thể loại này có nội dung thế nào. Nó làm cho bạn kinh hãi, khiếp sợ, ghê tởm, run rẩy, có thể gây sock - một thể loại không dành cho người yếu tim" },
                new DetailCategory() { Id = 7, CategoryId = 7, NameCategory = "Mature", SeoAlias = "/mature", SeoDescription = "Thể loại dành cho lứa tuổi 17+ bao gồm các pha bạo lực, máu me, chém giết, tình dục ở mức độ vừa" },
                new DetailCategory() { Id = 8, CategoryId = 8, NameCategory = "Manhwa", SeoAlias = "/manhwa", SeoDescription = "Truyện tranh Hàn Quốc, đọc từ trái sang phải" },
                new DetailCategory() { Id = 9, CategoryId = 9, NameCategory = "Manhua", SeoAlias = "/manhua", SeoDescription = "Truyện tranh của Trung Quốc" },
                new DetailCategory() { Id = 10, CategoryId = 10, NameCategory = "Ecchi", SeoAlias = "/ecchi", SeoDescription = "Thường có những tình huống nhạy cảm nhằm lôi cuốn người xem" },
                new DetailCategory() { Id = 11, CategoryId = 11, NameCategory = "Drama", SeoAlias = "/drama", SeoDescription = "Thể loại mang đến cho người xem những cảm xúc khác nhau: buồn bã, căng thẳng thậm chí là bi phẫn" },
                new DetailCategory() { Id = 12, CategoryId = 12, NameCategory = "Isekai", SeoAlias = "/isekai", SeoDescription = "Thể loại này là những câu chuyện về người ở một thế giới này xuyên đến một thế giới khác, có thể là thế giới mang phong cách trung cổ với kiếm sĩ và ma thuật, hay thế giới trong game, hoặc có thể là bạn chết ở nơi này và được chuyển sinh đến nơi khác" });

            modelBuilder.Entity<Author>().HasData(
                new Author() { Id = 1, DateCreated = DateTime.Now, NameAuthor = "Đường Gia Tam Thiếu", DifferentName = "Trương Uy", IsActive = true, SeoAlias = "duong-gia-tam-thieu" },
                new Author() { Id = 2, DateCreated = DateTime.Now, NameAuthor = "Thiên Tằm Thổ Đậu", DifferentName = "Lý Hổ", IsActive = true, SeoAlias = "thien-tam-tho-dau" },
                new Author() { Id = 3, DateCreated = DateTime.Now, NameAuthor = "Ogawa Makoto", DifferentName = "", IsActive = true, SeoAlias = "ogawa-makoto" },
                new Author() { Id = 4, DateCreated = DateTime.Now, NameAuthor = "Black Ajin", DifferentName = "", IsActive = true, SeoAlias = "black-ajin" },
                new Author() { Id = 5, DateCreated = DateTime.Now, NameAuthor = "Đang cập nhật", DifferentName = "", IsActive = true, SeoAlias = "dang-cap-nhat" });

            modelBuilder.Entity<ComicStrip>().HasData(
                new ComicStrip() { Id = 1, DateCreated = DateTime.Now, NameComic = "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", DifferentNameComic = "", ViewCount = 11111, IsActive = true, IdNewChapter = null, UrlCoverImageComic = "https://static.cdnno.com/poster/dau-la-dai-luc-trung-sinh-duong-tam/300.jpg?1621052117" },
                new ComicStrip() { Id = 2, DateCreated = DateTime.Now, NameComic = "Đấu Phá Thương Khung", DifferentNameComic = "", ViewCount = 312, IsActive = true, IdNewChapter = null, UrlCoverImageComic = "https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png" },
                new ComicStrip() { Id = 3, DateCreated = DateTime.Now, NameComic = "Khổng Minh Thích Tiệc Tùng", DifferentNameComic = "PARIPI KOUMEI; パリピ孔明", ViewCount = 5, IsActive = true, IdNewChapter = null, UrlCoverImageComic = "https://s199.imacdn.com/tt24/2022/04/26/7320277562288939_9aa537180a57276c_4220616509574003828291.jpg" },
                new ComicStrip() { Id = 4, DateCreated = DateTime.Now, NameComic = "Anh Hùng Trở Lại", DifferentNameComic = "Anh Hùng Trở Về; Anh Hùng Hồi Quy; The Hero Returns", ViewCount = 110, IsActive = true, IdNewChapter = null, UrlCoverImageComic = "https://i3.wp.com/nhattruyenz.com/images/anh-hung-tro-lai.jpg" },
                new ComicStrip() { Id = 5, DateCreated = DateTime.Now, NameComic = "Streamer Pháp Sư", DifferentNameComic = "", ViewCount = 880, IsActive = true, IdNewChapter = null, UrlCoverImageComic = "https://i3.wp.com/nhattruyenz.com/images/streamer-phap-su.jpg" });

            modelBuilder.Entity<DetailComic>().HasData(
                new DetailComic() { Id = 1, ComicId = 1, StatusId = 1, CountFollow = 0, CountRating = 0, Rating = 0, Description = "Một đời Thần Vương trùng sinh tại Pháp Lam thế giới thần kỳ, hắn kinh ngạc phát hiện, nơi này hết thảy đều là như vậy kỳ diệu, hắn càng là vận khí tuyệt hảo tìm được thê tử chuyển thế thân. Thế nhưng là, nàng không có trí nhớ của kiếp trước, gặp nhau lần nữa đã là người qua đường.", SeoDescription = "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam Một Phần Mới Của Tác Giả Đường Gia Tam Thiếu", SeoTitle = "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", SeoAlias = "/dau-la-dai-luc-trung-sinh-duong-tam-119313" },
                new DetailComic() { Id = 2, ComicId = 2, StatusId = 1, CountFollow = 0, CountRating = 0, Rating = 0, Description = "Đây là một thế giới thuộc về Đấu Khí, không hề có ma pháp hoa tiếu diễm lệ, chỉ có đấu khí cương mãnh phồn thịnh ! Tưởng tượng thế giới đó sẽ phát triển ra sao ? mời các bạn xem Đấu Phá Thương Khung!", SeoDescription = "Đấu Phá Thương Khung Một Trong Những Bộ Truyện Có Lượt Xem Nhiều Nhất", SeoTitle = "Đấu Phá Thương Khung", SeoAlias = "/dau-pha-thuong-khung-123813" },
                new DetailComic() { Id = 3, ComicId = 3, StatusId = 1, CountFollow = 0, CountRating = 0, Rating = 0, Description = "Bậc thầy quân sự nổi tiếng - Gia Cát Lượng Khổng Minh - người đã chết trong trận Ngũ Trượng Nguyên trở lại với cơ thể khi còn trẻ và tái sinh về Nhật Bản hiện đại. Được những người mê tiệc tùng ở Shibuya dẫn đi, Khổng Minh đã tới hộp đêm vang vọng tiếng nhạc EDM. Ở đó Khổng Minh đã gặp Tsukimi Eiko, người có mục tiêu trở thành ca sĩ, chính là người đã vén lên tấm ván cuộc sống thứ hai của ông. Người sống vì thiên hạ thái bình ở thời Tam Quốc như ông sẽ sống gì điều gì đây...!?", SeoDescription = "Gia Cát Lượng Khổng Minh - người đã chết trong trận Ngũ Trượng Nguyên trở lại với cơ thể khi còn trẻ và tái sinh về Nhật Bản hiện đại.", SeoTitle = "Gia Cát Lượng Khổng Minh", SeoAlias = "/khong-minh-thich-tiec-tung-813713" },
                new DetailComic() { Id = 4, ComicId = 4, StatusId = 1, CountFollow = 0, CountRating = 0, Rating = 0, Description = "Đệ nhất anh hùng của nhân loại, Kim Sung In.<br>Anh ấy bỏ mặc mọi thứ để quyết tâm lên đường chiến đấu  nhưng… Anh ấy vẫn không thể ngăn chặn sự hủy diệt của thế giới.<br>Tuy nhiên câu truyện huyền thoại của anh ấy chỉ mới bắt đầu khi anh ấy quay trở lại quá khứ vào 20 năm trước.", SeoDescription = "Câu truyện huyền thoại của anh ấy chỉ mới bắt đầu khi anh ấy quay trở lại quá khứ vào 20 năm trước.", SeoTitle = "Anh Hùng Trở Về", SeoAlias = "/anh-hung-tro-lai-590960" },
                new DetailComic() { Id = 5, ComicId = 5, StatusId = 1, CountFollow = 0, CountRating = 0, Rating = 0, Description = "Truyện tranh Streamer Pháp Sư được cập nhật nhanh và đầy đủ nhất tại HikiComic. Bạn đọc đừng quên để lại bình luận và chia sẻ, ủng hộ HikiComic ra các chương mới nhất của truyện Streamer Pháp Sư.", SeoDescription = "STREAMER PHÁP SƯ", SeoTitle = "STREAMER PHÁP SƯ", SeoAlias = "/streamer-phap-su-576390" });

            modelBuilder.Entity<CategoryInDetailComic>().HasData(
                new CategoryInDetailComic() { CategoryId = 1, DetailComicId = 1 },
                new CategoryInDetailComic() { CategoryId = 1, DetailComicId = 2 },
                new CategoryInDetailComic() { CategoryId = 3, DetailComicId = 2 },
                new CategoryInDetailComic() { CategoryId = 12, DetailComicId = 3},
                new CategoryInDetailComic() { CategoryId = 2, DetailComicId = 3 },
                new CategoryInDetailComic() { CategoryId = 8, DetailComicId = 4 },
                new CategoryInDetailComic() { CategoryId = 1, DetailComicId = 4 },
                new CategoryInDetailComic() { CategoryId = 12, DetailComicId = 4 },
                new CategoryInDetailComic() { CategoryId = 1, DetailComicId = 5 },
                new CategoryInDetailComic() { CategoryId = 8, DetailComicId = 5 });

            modelBuilder.Entity<AuthorInDetailComic>().HasData(
                new AuthorInDetailComic() { AuthorId = 1, DetailComicId = 1 },
                new AuthorInDetailComic() { AuthorId = 2, DetailComicId = 2 },
                new AuthorInDetailComic() { AuthorId = 3, DetailComicId = 3 },
                new AuthorInDetailComic() { AuthorId = 4, DetailComicId = 4 },
                new AuthorInDetailComic() { AuthorId = 5, DetailComicId = 5 });

            modelBuilder.Entity<ChapterComic>().HasData(
                new ChapterComic() { Id = 1, ComicId = 1, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 1", ViewCount = 0, SeoAlias = "/dau-la-dai-luc-trung-sinh-duong-tam-119313/chapter-1-284272" },
                new ChapterComic() { Id = 2, ComicId = 1, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 2", ViewCount = 0, SeoAlias = "/dau-la-dai-luc-trung-sinh-duong-tam-119313/chapter-2-524817" },
                new ChapterComic() { Id = 3, ComicId = 1, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 3", ViewCount = 0, SeoAlias = "/dau-la-dai-luc-trung-sinh-duong-tam-119313/chapter-3-846113" },
                new ChapterComic() { Id = 4, ComicId = 1, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 4", ViewCount = 0, SeoAlias = "/dau-la-dai-luc-trung-sinh-duong-tam-119313/chapter-4-247242" },
                new ChapterComic() { Id = 5, ComicId = 2, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 1", ViewCount = 0, SeoAlias = "/dau-pha-thuong-khung-123813/chapter-1-119211" },
                new ChapterComic() { Id = 6, ComicId = 2, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 1.5", ViewCount = 0, SeoAlias = "/dau-pha-thuong-khung-123813/chapter-1.5-249671" },
                new ChapterComic() { Id = 7, ComicId = 2, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 2", ViewCount = 0, SeoAlias = "/dau-pha-thuong-khung-123813/chapter-2-359611" },
                new ChapterComic() { Id = 8, ComicId = 3, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 1", ViewCount = 0, SeoAlias = "/khong-minh-thich-tiec-tung-813713/chapter-1-204813" },
                new ChapterComic() { Id = 9, ComicId = 4, DateCreated = DateTime.Now, IsActive = true, NameChapter = "Chapter 1", ViewCount = 0, SeoAlias = "/anh-hung-tro-lai-590960/chapter-1-947274" });

            modelBuilder.Entity<UrlImageComic>().HasData(
                new UrlImageComic() { Id = 1, ChapterComicId = 1, IsActive = true, UrlImageChapterComic = "|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg" },
                new UrlImageComic() { Id = 2, ChapterComicId = 2, IsActive = true, UrlImageChapterComic = "|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg" },
                new UrlImageComic() { Id = 3, ChapterComicId = 3, IsActive = true, UrlImageChapterComic = "|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg" },
                new UrlImageComic() { Id = 4, ChapterComicId = 4, IsActive = true, UrlImageChapterComic = "|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg|https://salt.tikicdn.com/ts/product/f6/b5/b7/6acaf61c8357d23e223b2fe5b9d065f0.jpg" },
                new UrlImageComic() { Id = 5, ChapterComicId = 5, IsActive = true, UrlImageChapterComic = "|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png" });

            modelBuilder.Entity<ListOfComicsUsersFollow>().HasData(
                new ListOfComicsUsersFollow() { Id = 1, AppUserId = adminId, ComicId = 1, DateFollow = DateTime.Now },
                new ListOfComicsUsersFollow() { Id = 2, AppUserId = adminId, ComicId = 2, DateFollow = DateTime.Now });

            modelBuilder.Entity<HistoryReadComicOfUser>().HasData(
                new HistoryReadComicOfUser() { Id = 1, AppUserId = adminId, ComicId = 1, ChapterId = 1, DateRead = DateTime.Now },
                new HistoryReadComicOfUser() { Id = 4, AppUserId = adminId, ComicId = 2, ChapterId = 6, DateRead = DateTime.Now });


        }
    }
}
