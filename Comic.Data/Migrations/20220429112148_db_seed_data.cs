using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comic.Data.Migrations
{
    public partial class db_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAuthor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DifferentName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoAlias = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsShowHome = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChapterComics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    NameChapter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoAlias = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterComics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameComic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DifferentNameComic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UrlCoverImageComic = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdNewChapter = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGender = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    NameCategory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SeoAlias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UrlImageComics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterComicId = table.Column<int>(type: "int", nullable: false),
                    UrlImageChapterComic = table.Column<string>(type: "varchar(7800)", unicode: false, maxLength: 7800, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlImageComics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrlImageComics_ChapterComics_ChapterComicId",
                        column: x => x.ChapterComicId,
                        principalTable: "ChapterComics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrlImageUser = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    MoreInfo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailComics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Description = table.Column<string>(type: "nvarchar(3800)", maxLength: 3800, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SeoAlias = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailComics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailComics_Comics_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailComics_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryReadComicOfUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    DateRead = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryReadComicOfUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryReadComicOfUsers_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryReadComicOfUsers_Comics_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListOfComicsUsersFollows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    DateFollow = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfComicsUsersFollows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfComicsUsersFollows_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfComicsUsersFollows_ChapterComics_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "ChapterComics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfComicsUsersFollows_Comics_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorInDetailComics",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    DetailComicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorInDetailComics", x => new { x.AuthorId, x.DetailComicId });
                    table.ForeignKey(
                        name: "FK_AuthorInDetailComics_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorInDetailComics_DetailComics_DetailComicId",
                        column: x => x.DetailComicId,
                        principalTable: "DetailComics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryInDetailComics",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DetailComicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryInDetailComics", x => new { x.CategoryId, x.DetailComicId });
                    table.ForeignKey(
                        name: "FK_CategoryInDetailComics_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryInDetailComics_DetailComics_DetailComicId",
                        column: x => x.DetailComicId,
                        principalTable: "DetailComics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2f0c7b75-8934-4101-bef2-c850e42d21de"), "442ab809-7685-4d16-b188-08978316b277", "Customer role", "customer", "customer" },
                    { new Guid("c489f858-aabd-4264-96c1-5cdca251d871"), "6fd923a6-0960-4d16-8d4b-54ea0674dd2b", "Staff role", "staff", "staff" },
                    { new Guid("e1db1200-1bb6-4156-9da3-135e91d94aba"), "70a20af4-d75b-4d38-bf84-8d83e5aca7c7", "Administrator role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateCreated", "DifferentName", "IsActive", "NameAuthor", "SeoAlias" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 29, 18, 21, 47, 726, DateTimeKind.Local).AddTicks(3487), "Trương Uy", true, "Đường Gia Tam Thiếu", "duong-gia-tam-thieu" },
                    { 2, new DateTime(2022, 4, 29, 18, 21, 47, 726, DateTimeKind.Local).AddTicks(3489), "Lý Hổ", true, "Thiên Tằm Thổ Đậu", "thien-tam-tho-dau" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "IsActive", "IsShowHome", "ParentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 29, 18, 21, 47, 726, DateTimeKind.Local).AddTicks(3426), true, true, null },
                    { 2, new DateTime(2022, 4, 29, 18, 21, 47, 726, DateTimeKind.Local).AddTicks(3436), true, true, null },
                    { 3, new DateTime(2022, 4, 29, 18, 21, 47, 726, DateTimeKind.Local).AddTicks(3437), true, true, null }
                });

            migrationBuilder.InsertData(
                table: "Comics",
                columns: new[] { "Id", "DateCreated", "DifferentNameComic", "IdNewChapter", "IsActive", "NameComic", "UrlCoverImageComic" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 29, 18, 21, 47, 726, DateTimeKind.Local).AddTicks(3504), "", null, true, "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", "https://static.cdnno.com/poster/dau-la-dai-luc-trung-sinh-duong-tam/300.jpg?1621052117" },
                    { 2, new DateTime(2022, 4, 29, 18, 21, 47, 726, DateTimeKind.Local).AddTicks(3507), "", null, true, "Đấu Phá Thương Khung", "https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "NameGender" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "NameStatus" },
                values: new object[,]
                {
                    { 1, "Còn sử dụng" },
                    { 2, "Hết sử dụng" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MoreInfo", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImageUser", "UserName" },
                values: new object[] { new Guid("0b64f6f0-9f60-45c9-9e7b-f68ccc3fc57f"), 0, "61f303b0-c3c3-4d19-a640-58b247c909c8", new DateTime(2001, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranquangbhdz@gmail.com", true, "Tran", 1, true, "Quang", false, null, "Chùm", "tranquangbhdz@gmail.com", "admin", "AQAAAAEAACcQAAAAEHGHOvIpnsPF8ItHKF5BQWPGp0sEWswy9jQCVEkZlrNbNBIhQy1uzE4tSZ3wnHNYbQ==", null, false, "", false, "https://64.media.tumblr.com/f3685609f6f9e0f15b70b740380fe0db/85dff69cc547be63-1d/s640x960/a0fa84e4ec96b338ec45f925baccc9619131013c.jpg", "admin" });

            migrationBuilder.InsertData(
                table: "DetailCategories",
                columns: new[] { "Id", "CategoryId", "NameCategory", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "Action", "action", "Thể loại hành động", "Hành Động" },
                    { 2, 2, "Slice of Life", "slice-of-life", "Thể loại nói về cuộc sống đời thường", "Cuộc Sống Đời Thường" },
                    { 3, 3, "Harem", "harem", "Thể loại truyện tình cảm, lãng mạn mà trong đó, nhiều nhân vật nữ thích một nam nhân vật chính", "Tình Cảm, Lãng Mạn, Nhiều Nữ Thích Một Nam" }
                });

            migrationBuilder.InsertData(
                table: "DetailComics",
                columns: new[] { "Id", "ComicId", "Description", "SeoAlias", "SeoDescription", "SeoTitle", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, "Một đời Thần Vương trùng sinh tại Pháp Lam thế giới thần kỳ, hắn kinh ngạc phát hiện, nơi này hết thảy đều là như vậy kỳ diệu, hắn càng là vận khí tuyệt hảo tìm được thê tử chuyển thế thân. Thế nhưng là, nàng không có trí nhớ của kiếp trước, gặp nhau lần nữa đã là người qua đường.", "dau-la-dai-luc-trung-sinh-duong-tam-119313", "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam Một Phần Mới Của Tác Giả Đường Gia Tam Thiếu", "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", 1 },
                    { 2, 2, "Đây là một thế giới thuộc về Đấu Khí, không hề có ma pháp hoa tiếu diễm lệ, chỉ có đấu khí cương mãnh phồn thịnh ! Tưởng tượng thế giới đó sẽ phát triển ra sao ? mời các bạn xem Đấu Phá Thương Khung!", "dau-pha-thuong-khung-123813", "Đấu Phá Thương Khung Một Trong Những Bộ Truyện Có Lượt Xem Nhiều Nhất", "Đấu Phá Thương Khung", 1 }
                });

            migrationBuilder.InsertData(
                table: "AuthorInDetailComics",
                columns: new[] { "AuthorId", "DetailComicId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CategoryInDetailComics",
                columns: new[] { "CategoryId", "DetailComicId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GenderId",
                table: "AppUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorInDetailComics_DetailComicId",
                table: "AuthorInDetailComics",
                column: "DetailComicId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryInDetailComics_DetailComicId",
                table: "CategoryInDetailComics",
                column: "DetailComicId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCategories_CategoryId",
                table: "DetailCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailComics_ComicId",
                table: "DetailComics",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailComics_StatusId",
                table: "DetailComics",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryReadComicOfUsers_AppUserId",
                table: "HistoryReadComicOfUsers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryReadComicOfUsers_ComicId",
                table: "HistoryReadComicOfUsers",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfComicsUsersFollows_AppUserId",
                table: "ListOfComicsUsersFollows",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfComicsUsersFollows_ChapterId",
                table: "ListOfComicsUsersFollows",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfComicsUsersFollows_ComicId",
                table: "ListOfComicsUsersFollows",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_UrlImageComics_ChapterComicId",
                table: "UrlImageComics",
                column: "ChapterComicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "AuthorInDetailComics");

            migrationBuilder.DropTable(
                name: "CategoryInDetailComics");

            migrationBuilder.DropTable(
                name: "DetailCategories");

            migrationBuilder.DropTable(
                name: "HistoryReadComicOfUsers");

            migrationBuilder.DropTable(
                name: "ListOfComicsUsersFollows");

            migrationBuilder.DropTable(
                name: "UrlImageComics");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "DetailComics");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "ChapterComics");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
