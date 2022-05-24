using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comic.Data.Migrations
{
    public partial class db_seed : Migration
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
                    IsShowHome = table.Column<bool>(type: "bit", nullable: false),
                    UrlImageCategory = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
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
                    RefreshToken = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    TokenCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    CountFollow = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CountRating = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
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
                    ChapterId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_HistoryReadComicOfUsers_ChapterComics_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "ChapterComics",
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
                    { new Guid("2f0c7b75-8934-4101-bef2-c850e42d21de"), "ed88513a-923b-474f-93fa-c2f6e9b18d7c", "Customer role", "customer", "customer" },
                    { new Guid("c489f858-aabd-4264-96c1-5cdca251d871"), "7560bcf9-4625-4879-8fb3-9d098be284b3", "Staff role", "staff", "staff" },
                    { new Guid("e1db1200-1bb6-4156-9da3-135e91d94aba"), "b5f5fe58-e5a5-4f1e-afd7-229e80106862", "Administrator role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateCreated", "DifferentName", "IsActive", "NameAuthor", "SeoAlias" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(635), "", true, "Đang cập nhật", "dang-cap-nhat" },
                    { 2, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(637), "Trương Uy", true, "Đường Gia Tam Thiếu", "duong-gia-tam-thieu" },
                    { 3, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(639), "Lý Hổ", true, "Thiên Tằm Thổ Đậu", "thien-tam-tho-dau" },
                    { 4, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(640), "", true, "Ogawa Makoto", "ogawa-makoto" },
                    { 5, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(641), "", true, "Black Ajin", "black-ajin" },
                    { 6, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(642), "", true, "Ân Tứ Giải Thoát", "an-tu-giai-thoat" },
                    { 7, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(643), "", true, "Oda Eiichiro", "oda-eiichiro" },
                    { 8, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(644), "", true, "Gosho Aoyama", "gosho-aoyama" },
                    { 9, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(645), "", true, "Ken Wakui", "ken-wakui" },
                    { 10, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(646), "", true, "Gotouge Koyoharu", "gotouge-koyoharu" },
                    { 11, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(647), "", true, "Horikoshi Kohei", "horikoshi-kohei" },
                    { 12, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(648), "", true, "Kishimoto Masashi", "kishimoto-masashi" },
                    { 13, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(649), "", true, "Jang Sung Lak", "jang-sung-lak" },
                    { 14, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(650), "", true, "Tabata Yuuki", "tabata-yuuki" },
                    { 15, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(651), "", true, "Shimabukuro Mitsutoshi", "shimabukuro-mitsutoshi" },
                    { 16, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(652), "", true, "Takehiko Inoue", "/takehiko-inoue" },
                    { 17, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(653), "", true, "Endou Tatsuya", "/endou-tatsuya" },
                    { 18, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(653), "", true, "Amano Akira", "/amano-akira" },
                    { 19, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(654), "", true, "Inagaki Riichiro", "/inagaki-riichiro" },
                    { 20, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(656), "", true, "Daromeon", "/daromeon" },
                    { 21, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(656), "", true, "Kusaba Michiteru", "/kusaba-michiteru" },
                    { 22, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(657), "", true, "Ookubo Atsushi", "/ookubo-atsushi" },
                    { 23, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(658), "", true, "Tsukuda Yuuto", "/tsukuda-yuuto" },
                    { 24, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(659), "", true, "Oku Hiroya", "/oku-hiroya" },
                    { 25, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(661), "", true, "Hiroshi Shiibashi", "/hiroshi-shiibashi" },
                    { 26, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(662), "", true, "Fukui Takumi", "/fukui-takumi" },
                    { 27, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(663), "", true, "Fujiko F. Fujio", "/fujiko-f.-fujio" },
                    { 28, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(663), "", true, "Matsumoto Naoya", "/matsumoto-naoya" },
                    { 29, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(664), "", true, "Akutami Gege", "/akutami-gege" },
                    { 30, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(665), "", true, "Yoshihiro Togashi", "/yoshihiro-togashi" },
                    { 31, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(666), "", true, "Isayama Hajime", "/isayama-hajime" },
                    { 32, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(667), "", true, "Boichi", "/boichi" },
                    { 33, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(668), "", true, "Takei Hiroyuki", "/takei-hiroyuki" },
                    { 34, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(669), "", true, "Nobuyuki Anzai", "/nobuyuki-anzai" },
                    { 35, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(670), "", true, "Hidenori Kusaka", "/hidenori-kusaka" },
                    { 36, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(670), "", true, "Yusei Matsui", "/yusei-matsui" },
                    { 37, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(672), "", true, "Tatsuki Fujimoto", "/tatsuki-fujimoto" },
                    { 38, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(673), "", true, "Toriyama Akira", "/toriyama-akira" },
                    { 39, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(674), "", true, "Fujisawa Tohru", "/fujisawa-tohru" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateCreated", "DifferentName", "IsActive", "NameAuthor", "SeoAlias" },
                values: new object[,]
                {
                    { 40, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(675), "", true, "Kubo Tite", "/kubo-tite" },
                    { 41, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(676), "", true, "Son Jae Ho", "/son-jae-ho" },
                    { 42, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(677), "", true, "Dong Wook Lee", "/dong-wook-lee" },
                    { 43, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(678), "", true, "Mashima Hiro", "/mashima-hiro" },
                    { 44, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(679), "", true, "Muneyuki Kaneshiro", "/muneyuki-kaneshiro" },
                    { 45, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(680), "", true, "TurtleMe", "/turtle-me" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "IsActive", "IsShowHome", "ParentId", "UrlImageCategory" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(504), true, true, null, "https://inkr.com/images/explore/action.svg" },
                    { 2, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(516), true, false, null, "https://inkr.com/images/explore/comedy.svg" },
                    { 3, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(517), true, true, null, "https://inkr.com/images/explore/comedy.svg" },
                    { 4, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(518), true, true, null, "https://inkr.com/images/explore/adventure.svg" },
                    { 5, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(518), true, true, null, "https://inkr.com/images/explore/romance.svg" },
                    { 6, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(521), true, true, null, "https://inkr.com/images/explore/horror.svg" },
                    { 7, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(521), true, false, null, "https://inkr.com/images/explore/mature.svg" },
                    { 8, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(522), true, true, null, "https://inkr.com/images/explore/comedy.svg" },
                    { 9, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(523), true, true, null, "https://inkr.com/images/explore/manhua.svg" },
                    { 10, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(524), true, true, null, "https://inkr.com/images/explore/comedy.svg" },
                    { 11, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(525), true, true, null, "https://inkr.com/images/explore/comedy.svg" },
                    { 12, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(525), true, false, null, "https://inkr.com/images/explore/comedy.svg" },
                    { 13, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(526), true, true, null, "https://inkr.com/images/explore/manga.svg" }
                });

            migrationBuilder.InsertData(
                table: "Comics",
                columns: new[] { "Id", "DateCreated", "DifferentNameComic", "IdNewChapter", "IsActive", "NameComic", "UrlCoverImageComic" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(710), "", null, true, "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", "https://static.cdnno.com/poster/dau-la-dai-luc-trung-sinh-duong-tam/300.jpg?1621052117" },
                    { 2, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(712), "", null, true, "Đấu Phá Thương Khung", "https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png" },
                    { 3, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(714), "PARIPI KOUMEI; パリピ孔明", null, true, "Khổng Minh Thích Tiệc Tùng", "https://s199.imacdn.com/tt24/2022/04/26/7320277562288939_9aa537180a57276c_4220616509574003828291.jpg" },
                    { 4, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(715), "Anh Hùng Trở Về; Anh Hùng Hồi Quy; The Hero Returns", null, true, "Anh Hùng Trở Lại", "https://i3.wp.com/nhattruyenz.com/images/anh-hung-tro-lai.jpg" },
                    { 5, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(716), "", null, true, "Streamer Pháp Sư", "https://i3.wp.com/nhattruyenz.com/images/streamer-phap-su.jpg" },
                    { 6, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(717), "", null, true, "Đấu Phá Thương Khung", "https://img.wattpad.com/cover/29835527-256-k284397.jpg" },
                    { 7, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(718), "The Hero Returns", null, true, "Anh Hùng Trở Lại", "https://i7.xem-truyen.com/manga/29/29645/hero_returns-manhwa-cover-flame.thumb_500x.png" },
                    { 8, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(719), "", null, true, "Đại Vương Tha Mạng", "https://truyenchu.vn/uploads/Images/dai-vuong-tha-mang.jpg" },
                    { 9, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(720), "", null, true, "Tu Tiên Trở Về Tại Vườn Trường", "https://tctruyen.com/upload/comic/tu-tien-tro-ve-tai-vuon-truong.jpg" },
                    { 10, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(721), "", null, true, "Võ Luyện Đỉnh Phong", "https://thuvienaudio.com/wp-content/uploads/2018/06/vu-luyen-dien-phong.jpg" },
                    { 11, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(722), "OnePiece", null, true, "Đảo Hải Tặc", "https://bloganchoi.com/wp-content/uploads/2021/09/one-piece-live-action-netlfix-2.jpg" },
                    { 12, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(723), "", null, true, "Bách Luyện Thành Thần", "https://i1.inkr.com/p/2020/6/27/9/2657858-222.png/180.webp" },
                    { 13, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(725), "Conan", null, true, "Thám Tử Conan", "https://i.pinimg.com/originals/c0/9f/24/c09f24575c942976d57157f10c475875.jpg" },
                    { 14, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(726), "Tokyo Revenge", null, true, "Kịch Trường Của Takemichi", "https://static.wikia.nocookie.net/tokyo-revengers/images/b/bb/US_Volume_03.png/revision/latest?cb=20200420123748" },
                    { 15, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(727), "Demon Slayer", null, true, "Thanh Gươm Diệt Quỷ", "https://cdn.mainichi.jp/vol1/2020/12/01/20201201p2a00m0na005000p/9.jpg?1" },
                    { 16, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(728), "Boku no Hero Academia", null, true, "Trường Học Siêu Anh Hùng", "https://i.pinimg.com/originals/c8/41/e7/c841e78626b3cf416ce1bc185e1543f6.png" },
                    { 17, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(729), "Ngã Vi Tà Đế", null, true, "Ta Là Tà Đế", "https://ucarecdn.com/4bd95f0e-aa9f-42bd-8463-37afc59746bb/" },
                    { 18, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(730), "Naruto", null, true, "Naruto - Cửu Vĩ Hồ Ly", "http://doublesama.com/wp-content/uploads/2018/01/8936534a37a0ca6b81e7c158d586f422-naruto-wallpaper-computer-wallpaper.jpg" },
                    { 19, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(731), "Solo Leveling", null, true, "Tôi thăng cấp một mình", "https://static.wikia.nocookie.net/solo-leveling/images/b/bf/Solo_Leveling_Returns.png/revision/latest?cb=20200715031557" },
                    { 20, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(732), "Black Clover", null, true, "Pháp sư không phép thuật", "https://media.voocdn.com/media/image/id/61dbc8780df938d60494273a_480x" },
                    { 21, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(733), "Toriko", null, true, "Thợ Săn Ẩm Thực", "https://static.wikia.nocookie.net/toriko/images/8/85/Volume_33.jpg/revision/latest?cb=20141224165805" },
                    { 22, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(735), "Slam Dunk", null, true, "Cao Thủ Bóng Rổ", "https://images-na.ssl-images-amazon.com/images/I/718nnN1TKqL.jpg" },
                    { 23, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(736), "Spy X Family", null, true, "Gia Đình Điệp Viên", "https://somoskudasai.com/wp-content/uploads/2021/10/2-scaled.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Comics",
                columns: new[] { "Id", "DateCreated", "DifferentNameComic", "IdNewChapter", "IsActive", "NameComic", "UrlCoverImageComic" },
                values: new object[,]
                {
                    { 24, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(737), "Katekyo Hitman Reborn!", null, true, "Reborn: Người đào tạo sát thủ", "https://preview.redd.it/wk7824ipdkw41.jpg?auto=webp&s=611520bfe104c3a536344f512c3c3e0601fdfe76" },
                    { 25, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(738), "Dr.Stone", null, true, "Hồi Sinh Thế Giới", "https://animecorner.me/wp-content/uploads/2022/03/Dr-Stone-WSJ-Cover.png" },
                    { 26, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(739), "Kengan Ashura", null, true, "Tokita Ouma - Đấu sĩ Atula", "https://vignette.wikia.nocookie.net/kenganashura/images/7/75/Vol0.jpg" },
                    { 27, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(740), "Cầu thủ trong mơ - Vũ điệu trên sân cỏ", null, true, "Fantasista bản VIP", "https://metruyentranh.com/images/covers/fantasista.jpg" },
                    { 28, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(745), "Enen no Shouboutai", null, true, "Biệt Đội Lính Cứu Hỏa", "https://i.pinimg.com/736x/da/cd/91/dacd91a6b12a3ebccd4dc4f71270586e.jpg" },
                    { 29, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(746), "Shokugeki no Souma", null, true, "Cuộc Chiến Ẩm Thực", "https://i.pinimg.com/originals/cf/7a/d0/cf7ad0e66d655108c1495b321c14e7d0.jpg" },
                    { 30, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(747), "Gantz", null, true, "Gantz Full Color", "https://i.pinimg.com/originals/50/eb/08/50eb086ba88dbf3c1f6b5a32c1c86d59.jpg" },
                    { 31, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(748), "Nurarihyon no Mago", null, true, "Bách Quỷ Dạ Hành", "https://c.wallhere.com/photos/be/b3/Nura_Rikuo_Nurarihyon_no_Mago-4877.jpg!d" },
                    { 32, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(751), "Record of Ragnarok", null, true, "Shuumatsu no Valkyrie", "https://www.coamix.co.jp/wp-content/uploads/2021/09/01.jpg" },
                    { 33, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(752), "Đôrêmon", null, true, "Doraemon", "https://upload.wikimedia.org/wikipedia/vi/thumb/1/16/Nobita_to_Midori_no_Kyojinden.jpg/300px-Nobita_to_Midori_no_Kyojinden.jpg" },
                    { 34, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(753), "Monster #8", null, true, "Hôm Nay - Tôi Hóa Kaiju", "http://creading.s3.us-east-2.amazonaws.com/wp-content/uploads/2021/08/21004034/monster8-cover-cornie.jpg" },
                    { 35, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(754), "Jujutsu Kaisen", null, true, "Chú Thuật Hồi Chiến", "https://image.cdnclouds.org/600x900,sc/https://media.cdnclouds.org/img-redirect/movies/2020/cau_lac_bo_huyen_bi_jujutsu_kaisen.jpg" },
                    { 36, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(755), "Hunter X Hunter", null, true, "Thế Giới Thợ Săn", "https://comichub.blob.core.windows.net/high/0c434519-1ffb-4a74-9e2b-e62fd6b136a9.jpg" },
                    { 37, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(756), "Attack on Titan", null, true, "Đại chiến Titan", "https://i.kym-cdn.com/photos/images/newsfeed/001/855/956/f2b" },
                    { 38, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(757), "", null, true, "Sun-ken Rock", "https://cdn-amz.fadoglobal.io/images/I/71HIeZK94xL.jpg" },
                    { 39, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(758), "Shaman King - Vua Pháp Thuật", null, true, "Vua Pháp Thuật", "https://pbs.twimg.com/media/D-1H031XYAALnnH.png" },
                    { 40, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(759), "MAR Heaven", null, true, "Mar", "https://i.pinimg.com/originals/8a/2b/15/8a2b158ecf6f61e9fc9a4f987a9493a8.jpg" },
                    { 41, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(761), "Pokemon Special", null, true, "Thú Cưng đặc biệt", "https://i.imgur.com/Pp1orgQ.jpg" },
                    { 42, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(762), "Ansatsu Kyoushitsu", null, true, "Hãy ám sát ta để cứu lấy trái đất", "https://i.pinimg.com/originals/3f/3c/c6/3f3cc60939290a3dd20d34cff3441ae3.jpg" },
                    { 43, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(763), "Yaiba Remake", null, true, "Yaiba", "https://vn-test-11.slatic.net/p/7c1759e3fbebdc59dde0954864977c71.jpg" },
                    { 44, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(765), "Chainsaw-man", null, true, "Thợ Săn Quỷ", "https://cdn-amz.fadoglobal.io/images/I/81ww5rFJirL.jpg" },
                    { 45, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(766), "DragonBall Super", null, true, "Truy Tìm Ngọc Rồng Siêu Cấp", "https://preview.redd.it/qyc2wpd6wpc71.jpg?auto=webp&s=a9109e6c5149c673f97ae1b6a3c359e115a513c2" },
                    { 46, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(767), "Great Teacher Onizuka - Tôi đi Tìm Tôi", null, true, "GTO - Great Teacher Onizuka", "https://static.wikia.nocookie.net/great-teacher-onizuka-gto/images/c/c0/GTO_Paradise_Lost_VOL_4.jpg/revision/latest?cb=20170721113457" },
                    { 47, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(768), "Dragon Ball", null, true, "Dragon Ball - Bảy Viên Ngọc Rồng", "https://i.pinimg.com/564x/15/98/79/1598798e5e449e300311ce396bf5774d.jpg" },
                    { 48, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(769), "Bleach", null, true, "Thần Chết Ichigo", "https://preview.redd.it/2o1poo5t8ck81.jpg?auto=webp&s=fe40bbc0cd8035fa500e513454e7bb26e662fdee" },
                    { 49, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(770), "Mèo Mặp Bẩn Bựa", null, true, "Eleceed", "https://m.media-amazon.com/images/I/41BTosIen7L.jpg" },
                    { 50, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(770), "Overgeared", null, true, "Thợ Rèn Huyền Thoại", "https://static.wikia.nocookie.net/overgeared/images/2/2a/Novel_Cover_3.png/revision/latest?cb=20210417213222" },
                    { 51, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(771), "Fairy Tail", null, true, "Hội Pháp Sư Nổi Tiếng", "https://cdn0.fahasa.com/media/catalog/product/f/t/ft_58_cover_1.jpg" },
                    { 52, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(772), "Blue Lock", null, true, "Tiền đạo số 1", "https://preview.redd.it/9ffxu339p3281.jpg?auto=webp&s=97c1277e764b36a05416d1c5076654341ee74e98" },
                    { 53, new DateTime(2022, 5, 24, 18, 58, 41, 859, DateTimeKind.Local).AddTicks(773), "The Beginning After The End", null, true, "Ánh Sáng Cuối Con Đường", "https://www.manga-kung.com/wp-content/uploads/2021/05/The-Beginning-After-the-End.jpg" }
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
                    { 1, "Đang tiến hành" },
                    { 2, "Hoàn thành" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MoreInfo", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "SecurityStamp", "TokenCreated", "TokenExpires", "TwoFactorEnabled", "UrlImageUser", "UserName" },
                values: new object[] { new Guid("0b64f6f0-9f60-45c9-9e7b-f68ccc3fc57f"), 0, "6fa07ba9-d811-4835-bdcf-2a9099d4a78a", new DateTime(2001, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranquangbhdz@gmail.com", true, "Tran", 1, true, "Quang", false, null, "Chùm", "tranquangbhdz@gmail.com", "admin", "AQAAAAEAACcQAAAAECyyq4Lc1FaQleGFd9e2ncYTOYjytvBHeiRkQeHvkzMPQByGK9dO7Vi2JPUOqPUb6Q==", null, false, null, "", null, null, false, "https://64.media.tumblr.com/f3685609f6f9e0f15b70b740380fe0db/85dff69cc547be63-1d/s640x960/a0fa84e4ec96b338ec45f925baccc9619131013c.jpg", "admin" });

            migrationBuilder.InsertData(
                table: "DetailCategories",
                columns: new[] { "Id", "CategoryId", "NameCategory", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "Action", "/action", "Thể loại hành động", "Hành Động" },
                    { 2, 2, "Slice of Life", "/slice-of-life", "Thể loại nói về cuộc sống đời thường", "Cuộc Sống Đời Thường" },
                    { 3, 3, "Harem", "/harem", "Thể loại truyện tình cảm, lãng mạn mà trong đó, nhiều nhân vật nữ thích một nam nhân vật chính", "Tình Cảm, Lãng Mạn, Nhiều Nữ Thích Một Nam" },
                    { 4, 4, "Adventure", "/adventure", "Thể loại phiêu lưu, mạo hiểm, thường là hành trình của các nhân vật", "Phiêu lưu, mạo hiểm" },
                    { 5, 5, "Romance", "/romance", "Thường là những câu chuyện về tình yêu, tình cảm lãng mạn. Ớ đây chúng ta sẽ lấy ví dụ như tình yêu giữa một người con trai và con gái, bên cạnh đó đặc điểm thể loại này là kích thích trí tưởng tượng của bạn về tình yêu", "Tình yêu, tình cảm lãng mạn giữa người con trai và con gái" },
                    { 6, 6, "Horror", "/horror", "Rùng rợn, nghe cái tên là bạn đã hiểu thể loại này có nội dung thế nào. Nó làm cho bạn kinh hãi, khiếp sợ, ghê tởm, run rẩy, có thể gây sock - một thể loại không dành cho người yếu tim", "Rùng rợn, kinh dị" },
                    { 7, 7, "Mature", "/mature", "Thể loại dành cho lứa tuổi 17+ bao gồm các pha bạo lực, máu me, chém giết, tình dục ở mức độ vừa", "Bạo lực, máu me" },
                    { 8, 8, "Manhwa", "/manhwa", "Truyện tranh Hàn Quốc, đọc từ trái sang phải", "Truyện tranh Hàn Quốc" },
                    { 9, 9, "Manhua", "/manhua", "Truyện tranh của Trung Quốc", "Truyện tranh Trung Quốc" },
                    { 10, 10, "Ecchi", "/ecchi", "Thường có những tình huống nhạy cảm nhằm lôi cuốn người xem", "" },
                    { 11, 11, "Drama", "/drama", "Thể loại mang đến cho người xem những cảm xúc khác nhau: buồn bã, căng thẳng thậm chí là bi phẫn", "Buồn bã, bi phẫn" },
                    { 12, 12, "Isekai", "/isekai", "Thể loại này là những câu chuyện về người ở một thế giới này xuyên đến một thế giới khác, có thể là thế giới mang phong cách trung cổ với kiếm sĩ và ma thuật, hay thế giới trong game, hoặc có thể là bạn chết ở nơi này và được chuyển sinh đến nơi khác", "Xuyên không" },
                    { 13, 13, "Manga", "/manga", "Truyện tranh của Nhật Bản", "Truyện tranh Nhật Bản" }
                });

            migrationBuilder.InsertData(
                table: "DetailComics",
                columns: new[] { "Id", "ComicId", "Description", "SeoAlias", "SeoDescription", "SeoTitle", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, "Một đời Thần Vương trùng sinh tại Pháp Lam thế giới thần kỳ, hắn kinh ngạc phát hiện, nơi này hết thảy đều là như vậy kỳ diệu, hắn càng là vận khí tuyệt hảo tìm được thê tử chuyển thế thân. Thế nhưng là, nàng không có trí nhớ của kiếp trước, gặp nhau lần nữa đã là người qua đường.", "/dau-la-dai-luc-trung-sinh-duong-tam-119313", "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam Một Phần Mới Của Tác Giả Đường Gia Tam Thiếu", "Đấu La Đại Lục Ⅴ Trùng Sinh Đường Tam", 1 },
                    { 2, 2, "Đây là một thế giới thuộc về Đấu Khí, không hề có ma pháp hoa tiếu diễm lệ, chỉ có đấu khí cương mãnh phồn thịnh ! Tưởng tượng thế giới đó sẽ phát triển ra sao ? mời các bạn xem Đấu Phá Thương Khung!", "/dau-pha-thuong-khung-123813", "Đấu Phá Thương Khung Một Trong Những Bộ Truyện Có Lượt Xem Nhiều Nhất", "Đấu Phá Thương Khung", 1 },
                    { 3, 3, "Bậc thầy quân sự nổi tiếng - Gia Cát Lượng Khổng Minh - người đã chết trong trận Ngũ Trượng Nguyên trở lại với cơ thể khi còn trẻ và tái sinh về Nhật Bản hiện đại. Được những người mê tiệc tùng ở Shibuya dẫn đi, Khổng Minh đã tới hộp đêm vang vọng tiếng nhạc EDM. Ở đó Khổng Minh đã gặp Tsukimi Eiko, người có mục tiêu trở thành ca sĩ, chính là người đã vén lên tấm ván cuộc sống thứ hai của ông. Người sống vì thiên hạ thái bình ở thời Tam Quốc như ông sẽ sống gì điều gì đây...!?", "/khong-minh-thich-tiec-tung-813713", "Gia Cát Lượng Khổng Minh - người đã chết trong trận Ngũ Trượng Nguyên trở lại với cơ thể khi còn trẻ và tái sinh về Nhật Bản hiện đại.", "Gia Cát Lượng Khổng Minh", 1 },
                    { 4, 4, "Đệ nhất anh hùng của nhân loại, Kim Sung In.<br>Anh ấy bỏ mặc mọi thứ để quyết tâm lên đường chiến đấu  nhưng… Anh ấy vẫn không thể ngăn chặn sự hủy diệt của thế giới.<br>Tuy nhiên câu truyện huyền thoại của anh ấy chỉ mới bắt đầu khi anh ấy quay trở lại quá khứ vào 20 năm trước.", "/anh-hung-tro-lai-590960", "Câu truyện huyền thoại của anh ấy chỉ mới bắt đầu khi anh ấy quay trở lại quá khứ vào 20 năm trước.", "Anh Hùng Trở Về", 1 },
                    { 5, 5, "Truyện tranh Streamer Pháp Sư được cập nhật nhanh và đầy đủ nhất tại HikiComic. Bạn đọc đừng quên để lại bình luận và chia sẻ, ủng hộ HikiComic ra các chương mới nhất của truyện Streamer Pháp Sư.", "/streamer-phap-su-576390", "STREAMER PHÁP SƯ", "STREAMER PHÁP SƯ", 1 },
                    { 6, 6, "Đây là một thế giới thuộc về Đấu Khí, không hề có ma pháp hoa tiếu diễm lệ, chỉ có đấu khí cương mãnh phồn thịnh!<br>Tưởng tượng thế giới đó sẽ phát triển ra sao ? mời các bạn xem Đấu Phá Thương Khung!<br>Hệ Thống Tu Luyện : Đấu Giả, Đấu Sư, Đại Đấu Sư, Đấu Linh, Đấu Vương, Đấu Hoàng, Đấu Tông, Đấu Tôn, Đấu Thánh, Đấu Đế.<br>Hãy Bắt Đầu Từ Tiêu Viêm ! Một thiên tài tu luyện trong phút chốc trở thành phế vật, từ phế vật lại từng bước khẳng định lại chính mình!<br>Hãy cùng bắt đầu cuộc hành trình đó với Đấu Phá Thương Khung", "/dau-pha-thuong-khung-563523", "", "", 1 },
                    { 7, 7, "[Từ tác giả của Thăng cấp cùng thần và Studio vẽ Cốt binh trở lại]<br>Đệ nhất anh hùng của nhân loại, Kim Sung In.<br>Anh ấy bỏ mặc mọi thứ để quyết tâm lên đường chiến đấu  nhưng… Anh ấy vẫn không thể ngăn chặn sự hủy diệt của thế giới.<br>Tuy nhiên câu truyện huyền thoại của anh ấy chỉ mới bắt đầu khi anh ấy quay trở lại quá khứ vào 20 năm trước.", "/anh-hung-tro-lai-121669", "", "", 1 },
                    { 8, 8, "Sau khi linh khí hồi phục, mọi người chắt chiu từng tơ linh khí, chỉ có Lữ Thụ, dựa vào hệ thống điểm cảm xúc tiêu cực , oán hận người khác là trở nên mạnh hơn! Cậu ta chỉ muốn bảo vệ em gái, nhưng mà thời kì lũ lụt khó có thể tránh khỏi, chỉ đành..... tiện oán hận người khác , trở nên mạnh hơn! Vậy thì , chuẩn bị xong chưa, Lữ Thụ 'Đại Ma Vương' tới đây", "/dai-vuong-tha-mang-371846", "", "", 1 },
                    { 9, 9, "Bị ám toán chết và trọng sinh về hiện đại đúng lúc...", "/tu-tien-tro-ve-tai-vuon-truong-486775", "", "", 1 },
                    { 10, 10, "Võ đạo đỉnh phong, là cô độc, là tịch mịch, là dài đằng đẵng cầu tác, là cao xử bất thắng hàn<br>Phát triển trong nghịch cảnh, cầu sinh nơi tuyệt địa, bất khuất không buông tha, mới có thể có thể phá võ chi cực đạo.<br>Lăng Tiêu các thí luyện đệ tử kiêm quét rác gã sai vặt Dương Khai ngẫu lấy được một bản vô tự hắc thư, từ nay về sau đạp vào dài đằng đẵng võ đạo.", "/vo-luyen-dinh-phong-287082", "", "", 1 },
                    { 11, 11, "One Piece xoay quanh 1 nhóm cướp biển được gọi là Băng Hải tặc Mũ Rơm - Straw Hat Pirates - được thành lập và lãnh đạo bởi thuyền trưởng Monkey D. Luffy. Cậu bé Luffy có ước mơ tìm thấy kho báu vĩ đại nhất, One Piece, của Vua Hải Tặc đời trước Gold D. Roger và trở thành Vua Hải Tặc đời kế tiếp. Ở Việt Nam hiện nay, truyện đang được Nhà xuất bản Thanh Hóa xuất bản nhưng không có bản quyền, với tên gọi là Đảo Hải tặc Cốt truyện: Monkey D. Luffy, 1 cậu bé rất thích hải tặc có ước mơ tìm được kho báu One Piece và trở thành Vua hải tặc - Pirate King. Lúc nhỏ, Luffy tình cờ ăn phải trái quỉ (Devil Fruit) Gomu Gomu, nó cho cơ thể cậu khả năng co dãn đàn hồi như cao su nhưng đổi lại cậu sẽ không bao giờ biết bơi. Sau đó Luffy lại được Shank cứu thoát tuy nhiên ông ta bị mất 1 cánh tay. Sau đấy Shank chia tay Luffy và để lại cho cậu cái mũ rơm (Straw Hat) và nói rằng: 'Sau này bao giờ thành cướp biển hãy gặp ta và trả lại nó'. Chính lời nói này đã thúc đầy Luffy trở thành 1 cướp biển thật sự.", "/dao-hai-tac-316711", "", "", 1 },
                    { 12, 12, "Cảnh giới: Luyện nhục cảnh, Luyện cốt cảnh, Luyện tạng cảnh....<br>La Chính vì gái mà bị đày làm nô bộc. La Bái Nhiên tham vọng đầy mình :))<br>La Chính lại vì gái mà đâm đầu tu luyện :))<br>La Gia trong phủ nước sôi lửa bỏng, tranh giành kịch liệt... thôi thì đọc tiếp sẽ biết :)<br>1 thanh niên dại gái tu luyện võ công =))", "/bach-luyen-thanh-than-832820", "", "", 1 },
                    { 13, 13, "Mở đầu câu truyện, cậu học sinh trung học 16 tuổi Shinichi Kudo bị biến thành cậu bé Conan Edogawa. Shinichi trong phần đầu của Thám tử lừng danh Conan được miêu tả là một thám tử học đường. Trong một lần đi chơi công viên 'Miền Nhiệt đới' với cô bạn từ thuở nhỏ (cũng là bạn gái) Ran Mori , cậu bị dính vào vụ án một hành khách trên Chuyến tàu tốc hành trong công viên, Kishida , bị giết trong một vụ án cắt đầu rùng rợn. Cậu đã làm sáng tỏ vụ án và trên đường về nhà, chứng kiến một vụ làm ăn mờ ám của những người đàn ông mặc toàn đồ đen. Kudo bị phát hiện, bị đánh ngất sau đó những người đàn ông áo đen đã cho cậu uống một thứ thuốc độc chưa qua thử nghiệm là Apotoxin-4869 (APTX4869) với mục đích thủ tiêu cậu. Tuy nhiên chất độc đã không giết chết Kudo. Khi tỉnh lại, cậu bàng hoàng nhận thấy thân thể mình đã bị teo nhỏ trong hình dạng của một cậu học sinh tiểu học....", "/tham-tu-conan-276186", "", "", 1 },
                    { 14, 14, "Tên khác: Tokyo Manji Revengers Tokyo Revengers Toukyou Revengers 東京卍リベンジャーズ<br>Takemichi, thanh niên thất nghiệp còn trinh, được biết rằng người con gái đầu tiên và cũng là duy nhất cho đến bây giờ mà anh hẹn hò từ trung học đã chết. Sau một vụ tai nạn, anh ta thấy mình được quay về những ngày cấp hai. Anh ta thề sẽ thay đổi tương lai và giữ lấy người con gái ấy, để làm việc đó, anh ta quyết định sẽ vươn lên làm trùm băng đảng khét tiếng nhất ở vùng Kantou.<br>Ủng hộ bọn mình tại FB: https://www.facebook.com/quangbdhz/", "/kich-truong-cua-takemichi-285355", "", "", 1 },
                    { 15, 15, "Kimetsu no Yaiba – Tanjirou là con cả của gia đình vừa mất cha. Một ngày nọ, Tanjirou đến thăm thị trấn khác để bán than, khi đêm về cậu ở nghỉ tại nhà người khác thay vì về nhà vì lời đồn thổi về ác quỷ luôn rình mò gần núi vào buổi tối. Khi cậu về nhà vào ngày hôm sau, bị kịch đang đợi chờ cậu…", "/thanh-guom-diet-quy-795593", "", "", 1 },
                    { 16, 16, "Câu chuyện lấy bối cảnh thời hiện đại, có khác một điều là những người có năng lực đặc biệt lại trở nên quá đỗi bình thường. Một cậu bé tên Midoriya Izuku tuy không có năng lực gì nhưng cậu vẫn mơ ước...", "/truong-hoc-sieu-anh-hung-998808", "", "", 1 },
                    { 17, 17, "Truyện tranh Ta Là Tà Đế được cập nhật nhanh và đầy đủ nhất tại NetTruyen. Bạn đọc đừng quên để lại bình luận và chia sẻ, ủng hộ NetTruyen ra các chương mới nhất của truyện Ta Là Tà Đế.", "/ta-la-ta-de-772343", "", "", 1 },
                    { 18, 18, "Naruto là một cậu bé có mơ ước trở thành hokage của làng Konoha,được Hokage phong ấn trong người một trong 9 quái vật của thể giới : Cửu vĩ Hồ ly.Vì cho cậu là một con quái vật, ko ai dám chơi với cậu!& Vì muốn được thừa nhận nên rất phá phách.Khi tốt nghiệp trướng ninja, lần đầu tiên cậu đã được thừa nhận và có một người bạn thân là Sasuke.Hai năm sau, Sasuke đã rời bỏ làng lá để đi theo Orochimaru vì muốn đạt được sức mạnh hơn người, và dùng sức mạnh đó để giết người anh của mình.Naruto muốn đem Sasuke trở về, và vì Kakashi ko đủ trình độ nên đã đi theo Jiraiya - một trong tam nin truyền thuyết của Konoha - để học tập thêm cách dùng sức mạnh.Sau hai năm trờ về, Naruto đã 16 tuổi và có nhiều thay đổi! Và những khó khăn nguy hiểm cũng từ đó tăng lên 2 năm sau Sasuke đã trưởng thành...và đúng với cái tên thiên tài Uchiha cậu đã hạ được Orochimaru ( tất nhiên là lúc hắn đang bị ấn chú của Đệ tam làm yếu nhất ) và phong ấn hắn trong người cậu. Cậu cùng Suigetsu , Juugo và Karin thành lập Mãng xà truy tìm Itachi. Naruto Sakura Choiji Sai Ino Shikamaru Kiba Shino....cũng dần trở thành những ninja mạnh mẽ trụ cột của làng lá. Họ đã hạ được 2 thành viên Akatsuki. Cũng như Sasuke hạ được Deidara Sasuke và Itachi đã gặp nhau. Và trận chiến cuối cùng đã xảy ra với chiến thắng của Sasuke. Madara xuất hiện và sự thật về Itachi đã đc hé lộ...bí mật về Gia tộc Uchiha và Làng Lá đã tạo nên bi kịch giữa Sasuke và Itachi. Nhóm Đại Bàng được thành lập kết hợp cùng Akatsuki chính thức truy tìm 9 quái vật có đuôi và bắt đầu kế hoạch trả thù của Sasuke ..........", "/naruto-cuu-vi-ho-ly-826269", "", "", 1 },
                    { 19, 19, "Theo chân Sung JinWoo trên hành trình từ 'thợ săn kém cỏi' đến 'thợ săn hạng S mạnh nhất thế giới'. (có 1 tí Saitama với 1 tí The gamer, bạn nào thích 2 bộ này xin mời nhảy hố=)", "/toi-thang-cap-mot-minh-471159", "", "", 1 },
                    { 20, 20, "Astar và Yuno là hai đứa trẻ bị bỏ rơi ở nhà thờ và cùng nhau lớn lên tại đó. Khi còn nhỏ, chúng đã hứa với nhau xem ai sẽ trở thành Ma pháp vương tiếp theo. Thế nhưng, khi cả hai lớn lên, mọi sô chuyện đã thay đổi. Yuno là thiên tài ma pháp với sức mạnh tuyệt đỉnh trong khi Aster lại không thể sử dụng ma pháp và cố gắng bù đắp bằng thể lực. Khi cả hai được nhận sách phép vào tuổi 15, Yuno đã được ban cuốn sách phép cỏ bốn bá (trong khi đa số là cỏ ba lá) mà Aster lại không có cuốn nào. Tuy nhiên, khi Yuno bị đe dọa, sự thật về sức mạnh của Aster đã được giải mã- cậu ta được ban cuốn sách phép cỏ năm lá, cuốn sách phá ma thuật màu đen. Bấy giờ, hai người bạn trẻ đang hướng ra thế giới, cùng chung mục tiêu", "/phap-su-khong-phep-thuat-937091", "", "", 1 },
                    { 21, 21, "Câu chuyện kể vể Toriko một thợ săn pro thường xuyên cung cấp các loại thực phẩm quý giá cho nhà hàng và những người giàu có, một anh chàng có đầy sức mạnh để săn bắt các loài động vật hung dữ . Đây là một bộ manga mới phát hành 1 năm rưỡi nhưng đang đứng thứ 4 về mức độ yêu thích của các độc giả Weeky Jump (sau One Piece Naturo Bleach) , mặc dù vậy nhưng Toriko chưa được scan (lậu) rộng rãi.", "/tho-san-am-thuc-821174", "", "", 1 },
                    { 22, 22, "Slam Dunk nói về đội bóng rổ của một trường cấp 3 mang tên Shohoku. Nhân vật chính của bộ manga này là Hanamichi Sakuragi, một kẻ giữ kỉ lục 'T bình phương' (thất tình), có sức mạnh vượt trội và rất nóng máu, đứng đầu một nhóm học sinh chuyên quậy phá. Một lần tình cờ, cậu ta quen được Haruko Akagi - cô gái trong mộng và cậu cảm thấy hạnh phúc cực kì khi cô ấy không sợ cậu như những cô gái khác. Haruko người đã nhận ra khả năng tiềm ẩn của Hanamichi, đã giới thiệu cậu vào đội bóng rổ trường Shohoku. Hanamichi lúc đầu cũng không khoái môn bóng rổ cho lắm vì cậu chưa từng chơi bất kì môn thể thao nào trước đó. Thêm nữa, Hanamichi cho rằng bóng rổ là môn thể thao dành cho kẻ thua cuộc (cô gái thứ 15 mà Hanamichi tỏ tình đã từ chối cậu vì cô ấy để ý đến một anh chàng ở đội bóng rổ). Hanamichi, bỏ qua bản tính thiếu kiên trì và hay nóng máu của mình, đã tham gia vào đội bóng rổ để gây sự chú ý của Haruko và cải thiện hình ảnh tệ hại về bản thân ở cô. Kaede Rukawa - đối thủ cứng đầu của Hanamichi (cả trong bóng rổ cũng như trong truyện tình cảm, mặc dù Rukawa không biết rằng Haruko đang để ý hắn), là một ngôi sao nổi tiếng và cực kì... sát gái, cũng gia nhập cùng lúc đó. Hisashi Mitsui, cựu MVP khối cấp hai, và Ryota Miyagi, một cầu thủ 'lùn mà lẹ', cùng lúc trở lại đội bóng trở thành một bộ tứ cùng với đội trưởng Takenori Akagi với ước mơ đưa Shohoku tới giải quốc gia. Cũng lúc đó, các đội bóng rổ bắt đầu để ý đến đội bóng 'toàn sao' Shohoku. Slam Dunk là một trong những bộ manga thể thao mang tính hiện thực. Các nhân vật không phải là những người có tài năng sẵn có, không cần phải cố gắng, và Shokoku không phải luôn luôn chiến thắng. Sự trưởng thành của Hanamichi khá đặc biệt, hắn trưởng thành từ từ và cố gắng hết sức để đạt được thành quả. Slam Dunk đã được TVM Comics chính thức mua bản quyền xuất bản tại Việt Nam vào năm 2009 với tập 1 ra mắt vào tháng 2 năm 2009. NXB tại Nhật: Shueisha.", "/cao-thu-bong-ro-303271", "", "", 1 },
                    { 23, 23, "Anh điệp viên lấy vợ sát thủ và có con siêu năng", "/gia-dinh-diep-vien-750279", "", "", 1 },
                    { 24, 24, "Đây là 1 trong các manga shounen đang “HOT” nhất tại Nhật. Manga nói về Tsunayoshi Sawada, 1 học sinh trung học tầm thường, thường bị mọi người đặt cho biệt danh “Tsuna Vô Dụng”. Vì sự vô dụng này mà mẹ cậu đã thuê 1 gia sư đặc biệc cho Tsuna theo lời quảng cáo trong '1 tờ rơi' như sau:<br>“…Sẽ huấn luyện con bạn trở thành 1 thủ lĩnh hàng đầu trong thời đại mới”<br>“Học vấn không là vấn đề. Reborn!”<br>Nhưng… đằng sau đó là 1 sự thật kinh hoàng đang chờ đón Tsuna…<br>“Đừng có mà xem thường. Nghề chính của tui là sát thủ đó. Nhiệm vụ thật sự lần này là đào tạo cậu thành 1 ông chủ Mafia xuất sắc nhất.”<br>“ Còn việc dạy như thế nào là chuyện của tui.”<br>Tương lai và số phận của Tsuna rồi sẽ ra sao… khi cuộc sống luôn cận kệ 'cái chết' của cậu bắt đầu từ đó...?", "/reborn-nguoi-dao-tao-sat-thu-439385", "", "", 1 },
                    { 25, 25, "Sau 1 trận đại dịch không rõ nguồn gốc khiến loài người trên toàn thể địa cầu biến thành đá trải qua mấy ngàn năm sau 2 thanh niên chính của chúng ta là Senkuu và Taiju phá đá thoát ra và bắt đầu lập kế hoạch để cùng nhau tái thiết lập lại thế giới theo cách của họ", "/hoi-sinh-the-gioi-796907", "", "", 1 },
                    { 26, 26, "Từ thời Edo đã tồn tại các đầu trường, mà tại đó các thương gia thuê đấu sĩ đấu tay không với nhau, bên nào thắng sẽ có tất cả. Tokita Ouma, biệt danh là 'Ashura' tham gia đấu trường và đánh thắng tất cả các đấu thủ của mình. Khả năng đặc biết đè bẹp mọi đối thủ của cậu ta đã được các ông chủ tập đoàn lớn để ý, trong đó có chủ tịch tập đoàn Nogi, Nogi Hideki", "/tokita-ouma-dau-si-atula-583878", "", "", 1 },
                    { 27, 27, "Đây là bộ truyện tranh về bóng đá nổi tiếng! chắc hẳn các fan của môn thể thao vua đều biết, và nay truyện đã được edit lại hoàn toàn mới với chất lượng tuyệt đẹp", "/fantasista-ban-vip-171375", "", "", 1 },
                    { 28, 28, "Thanh niên nghịch lửa", "/biet-doi-linh-cuu-hoa-144575", "", "", 1 }
                });

            migrationBuilder.InsertData(
                table: "DetailComics",
                columns: new[] { "Id", "ComicId", "Description", "SeoAlias", "SeoDescription", "SeoTitle", "StatusId" },
                values: new object[,]
                {
                    { 29, 29, "Cậu trai trẻ Yukihira Souma là con nhà nòi của 1 quán ăn bình dân , cậu có 1 khao khát cháy bỏng là vượt qua cha mình người đã đánh bại cậu liên tục 489 trận ( mặc dù trình nấu ăn của anh Main cũng thần thánh không kém ) . Đến 1 ngày cậu nghe lời cha mình để vào trường đào tạo tài năng ẩm thực . Câu chuyện đời cậu sắp bước sang 1 ngã rẻ khác nhìu thú vị hơn...", "/cuoc-chien-am-thuc-573131", "", "", 1 },
                    { 30, 30, "Bản này do 1 team bên bờ ra xin tô màu lại nhưng raw của họ phải nói là chất lượng khá kém cho nên là những chap về đầu xem cv thể hơi hoa mắt các bạn thông cảm", "/gantz-full-color-764974", "", "", 1 },
                    { 31, 31, "Rikuo là một cậu bé mang trong mình 2 dòng máu, một nửa là con người, nửa kia là yêu quái, sống trong một ngôi nhà đầy yêu quái với ông nội. Số mệnh của cậu là trở thành Nurarihyon- thống lĩnh yêu quái, nhưng trớ trêu là cậu lại chỉ muốn sống một cuộc đời của 1 con người bình thường... Quyết định của Rikuo sẽ là gì? Trở thành Thống lĩnh yêu quái hay làm con người? Muốn biết kết cục hãy đón xem truyện :P", "/bach-quy-da-hanh-418862", "", "", 1 },
                    { 32, 32, "Các vị thần mở hội nghị để bàn về sự sống còn của nhân loại. Tất cả đều quyết định 'kết liễu' con người, chỉ duy một valkyrie đứng lên phản đối bằng cách đề nghị 1 cuộc chiến giữa thần và người. Cuộc chiến quyết định số phận của nhân loại này sẽ ra sao? Xin mời đón đọc.", "/shuumatsu-no-valkyrie-907778", "", "", 1 },
                    { 33, 33, "Đôrêmon là một chú mèo máy được Nôbita, cháu ba đời của Nôbita gửi về quá khứ cho ông mình để giúp đỡ Nôbita tiến bộ, tức là cũng sẽ cải thiện hoàn cảnh của con cháu Nôbita sau này. Còn ở hiện tại, Nôbita là một cậu bé luôn thất bại ở trường học, và sau đó là thất bại trong công việc, đẩy gia đình và con cháu sau này vào cảnh nợ nần. Các câu chuyện trong Đôrêmon thường có một công thức chung, đó là xoay quanh những rắc rối hay xảy ra với cậu bé Nôbita lớp bốn, nhân vật chính thứ nhì của bộ truyện. Đôrêmon có một chiếc túi thần kỳ trước bụng với đủ loại bảo bối của tương lai. Cốt truyện thường gặp nhất sẽ là Nôbita trở về nhà khóc lóc với những rắc rối mà cậu gặp phải ở trường hoặc với bạn bè. Sau khi bị cậu bé van nài hoặc thúc giục, Đôrêmon sẽ đưa ra một bảo bối giúp Nôbita giải quyết những rắc rối của mình, hoặc là để trả đũa hay khoe khoang với bạn bè của cậu. Nôbita sẽ lại thường đi quá xa so với dự định ban đầu của Đôrêmon, thậm chí với những bảo bối mới cậu còn gặp rắc rối lớn hơn trước đó. Đôi khi những người bạn của Nôbita (thường là Xêkô hoặc Chaien) lại lấy trộm những bảo bối và sử dụng chúng không đúng mục đích. Tuy nhiên thường thì ở cuối mỗi câu chuyện, những ai sử dụng sai mục đích bảo bối sẽ phải chịu hậu quả do mình gây ra, và người đọc sẽ rút ra được bài học đạo đức từ đó.", "/doraemon-501945", "", "", 1 },
                    { 34, 34, "Hibino Kafka một thanh niên vốn bất mãn với việc làm tại công ty vệ sinh chịu trách nhiệm xử lí xác kaiju. Sau khi bị thương bởi một trận tấn công bất ngờ lại bỗng nhiên hóa thành kaiju! Dưới hình dạng mới, ước mơ và lời hứa khi xưa với cô bạn thuở nhỏ đã có thể thực hiện được", "/hom-nay-toi-hoa-kaiju-492520", "", "", 1 },
                    { 35, 35, "Yuuji Itadori là một thiên tài có tốc độ và sức mạnh, nhưng cậu ấy muốn dành thời gian của mình trong Câu lạc bộ Tâm Linh. Một ngày sau cái chết của ông mình, anh gặp Megumi Fushiguro, người đang tìm kiếm vật thể bị nguyền rủa mà các thành viên CLB đã tìm thấy.<br>Đối mặt với những con quái vật khủng khiếp bị 'Ám', Yuuji nuốt vật thể bị phong ấn để có được sức mạnh của nó và cứu bạn bè của mình! Nhưng giờ Yuuji là người bị 'Ám', và cậu ấy sẽ bị kéo vào thế giới ma quỷ ly kỳ của Megumi và những con quái vật độc ác ...", "/chu-thuat-hoi-chien-500585", "", "", 1 },
                    { 36, 36, "Một thế giới giả tưởng với các thợ săn lùng mọi cảm giác. Gon, nhân vật chính của truyện, sau khi biết cha mình vẫn còn sống và là một hunter tài năng, đã quyết tâm trở thành một thợ săn. Trong cuộc thi tuyển chọn hunter, Gon đã gặp và kết bạn với Killua, Kurapika và Leorio. Câu truyện lôi cuốn người đọc bởi những nhân vật ấn tượng.", "/the-gioi-tho-san-664370", "", "", 1 },
                    { 37, 37, "Hơn 100 năm trước, giống người khổng lồ Titan đã tấn công và đẩy loài người tới bờ vực tuyệt chủng. Những con người sống sót tụ tập lại, xây bao quanh mình 1 tòa thành 3 lớp kiên cố và tự nhốt mình bên trong để trốn tránh những cuộc tấn công của người khổng lồ. Họ tìm mọi cách để tiêu diệt người khổng lồ nhưng không thành công. Và sau 1 thế kỉ hòa bình, giống khổng lồ đã xuất hiện trở lại, một lần nữa đe dọa sự tồn vong của con người....<br>Elen và cô em gái Mikasa phải chứng kiến một cảnh tượng cực kinh khủng - mẹ của mình bị ăn thịt ngay trước mắt. Elen thề rằng cậu sẽ giết tất cả những tên khổng lồ mà cậu gặp...", "/dai-chien-titan-400872", "", "", 1 },
                    { 38, 38, "Truyện kể về Ken - một chàng trai Nhật Bản yêu một cô gái Hàn Quốc tên Yumin.<br>Vì tiếng gọi của tình yêu, anh đã theo cô sang Hàn và muốn trở thành cảnh sát như Yumin.<br>Nhưng Ken đã bị cuốn vào vòng xoáy của xã hội đen với hành trình tranh giành địa bàn vô cùng khốc liệt...<br>Máu - Nước mắt - Niềm tin vào chính nghĩa... là những gì bạn sẽ tìm thấy khi đọc Sun-Ken Rock.", "/sun-ken-rock-715018", "", "", 1 },
                    { 39, 39, "Trong thế giới của Shaman King có những shaman (pháp sư), là các phù thủy có thể điều khiển được các linh hồn. Mỗi pháp sư có một linh hồn đi kèm để hỗ trợ. Cứ 500 năm 1 lần sẽ có một đại hội thi đấu giữa các pháp sư để chọn ra một vua pháp sư. Người này sẽ có được linh hồn vĩ đại của Trái Đất để giúp thế giới. Tuy nhiên 2 cuộc thi đấu gần đây nhất đã bị phá hoại bởi một pháp sư tên là Asakura Hao. Manta là một cậu bé đang học trung học ở Tokyo. Cậu tình cờ làm quen với Yoh, một pháp sư mới chuyển đến cùng lớp. Manta lần lượt gặp những pháp sư khác như Anna, Ryu, Tao Ren, Tao Jun. Shaman King kể về cuộc phiêu lưu của Yoh, Anna, và các bạn qua lời kể của Manta.", "/vua-phap-thuat-997895", "", "", 1 },
                    { 40, 40, "Ginta là học sinh năm thứ 2 cao trung, có thể chất yếu ớt (thị lực cả 2 mắt là 0,1/10 vì chơi game quá nhiều) nên hay bị bạn bè bắt nạt. Ginta luôn có những giấc mơ về những điều kỳ diệu và thường thả hồn mình bay đến các vùng đất xa xôi, bí ẩn. Rồi một ngày kia, cậu được con quái vật mang đến thế giới mà cậu thường mơ thấy: Thiên Đường Thần Tiên...", "/mar-987431", "", "", 1 },
                    { 41, 41, "Truyện được chia thành nhiều Arc tương tự như trong Game là Red/Blue; Yellow; Gold/Silver; Crystal; Ruby/Sapphire; Fire Red/Leaf Green; Emerald và hiện giờ đang đến Arc mới nhất là Diamond và Pearl. Mỗi Arc lại kết nối mật thiết với nhau làm thành một bộ Manga Pokemon với rất nhiều nhân vật và Pokemon đa dạng. Với nội dung hoàn toàn khác so với Pokemon Anime, đây hứa hẹn là một trong những bộ truyện hay bạn nên xem ^_^<br>Đọc truyện từ trái sang phải nhé", "/thu-cung-dac-biet-906137", "", "", 1 },
                    { 42, 42, "“Ta là người đã phá huỷ mặt trăng”<br>“Hãy ám sát ta nếu các ngươi muốn cứu lấy trái đất”.<br>Một con bạch tuột chẳng biết tự lỗ nào chui lên cứ luôn miệng gào thét hai câu này và đòi làm thầy giáo của đám học sinh cá biệt lớp 3-E. Chẳng hiểu hắn đang nghĩ cái quái gì khi bản thân không muốn chết nhưng cứ thích khuyến khích người ta ám sát mình. Để coi cái lớp học sát thủ này rồi sẽ đi về đâu...", "/hay-am-sat-ta-de-cuu-lay-trai-dat-666331", "", "", 1 },
                    { 43, 43, "Đây là một câu chuyện hài hước, vui nhộn về một cậu bé tên Kurogane Yaiba. Yaiba sống với cha trong rừng. Một ngày nọ, khi Yaiba đang ăn, một đàn khỉ đột xông đến tấn công 2 cha con cậu. Yaiba và cha trốn thoát và trốn vào trong một cái hộp, nhưng họ không hề biết rằng cái hộp đó chứa đầy quả thơm và đang được chuẩn bị đem vào thành phố. Trong thành phố, Yaiba được biết rằng cậu là một chiến binh huyền thoại và phải chiến đấu chống lại tên yêu ma có hình dạng của một học sinh mang tên Takeshi.", "/yaiba-734384", "", "", 1 },
                    { 44, 44, "Tác giả của 'Fire Punch' lần đầu tiên xuất hiện trên Shonen Jump với câu chuyện về một Dark Hero!<br>Cậu thiếu niên Denji sống một cuộc sống nghèo khổ và phải làm việc vất vả để trả nợ. Cậu vừa sống vừa làm Thợ Săn Qủy cùng với Pochita - loài quỷ Chainsaw, nhưng rồi một ngày cậu trở thành mục tiêu của mọt con quỷ tàn bạo...", "/tho-san-quy-859076", "", "", 1 },
                    { 45, 45, "Câu chuyện của Dragon Ball Super diễn ra ngay sau khi chiến đấu với Ma Nhân Bư, cuộc sống ở trái đất lại được hòa bình thêm 1 lần nữa. Sau đó vì nhà gần như hết tiền để chi tiêu Chichi tiền ra lệnh cho Goku phải đi kiếm tiền, và không được phép luyện tập trong thời gian này!! Videl sắp trở thành chị dâu của Goten nên Goten đã đặt ra một cuộc hành trình cùng với TRunks để tìm cho Videl một món quà!", "/truy-tim-ngoc-rong-sieu-cap-149314", "", "", 1 },
                    { 46, 46, "Eikichi Onizuka, 22 tuổi và là thành viên của một nhóm Boosoozok(một nhóm đua xe tụ tập lại với nhau từ nhiều thành viên, giống kiểu như băng đảng vậy.) Và Onizuka ước muốn được trở thành người thầy vĩ đại nhất của Nhật Bản sau khi người bạn gái đầu tiên bị cướp đi bởi một ông thầy giáo.Nhưng oái ăm thay, thầy giáo Onizuka lại được phân vào một lớp học với thành tích trong 1 tháng thay 3 lần giáo viên chỉ bởi những trò đùa quái ác mà lũ học trò tinh quái này gây ra. Và thầy giáo vĩ đại Onizuka xuất hiện, thay đổi cả bộ mặt cho trường và cho lớp 7-4 này ^^! Từng bước thầy giải tỏa được những bức xúc của mỗi học trò bởi lòng nhiệt tình và am hiểu suy nghĩ của những học sinh thời nay.<br>Chính nhờ lòng nhiệt tình, ko ngại khó khăn, từng bước Onizuka sensei đã cải hóa được suy nghĩ theo chiều hướng xấu của học sinh, giúp cho những 'tương lai' của đất nước có những suy nghĩ đúng đắn hơn về bản thân, về gia đình và về xã hội", "/gto-great-teacher-onizuka-205527", "", "", 1 },
                    { 47, 47, "Một cậu bé có đuôi khỉ tên là Goku được tìm thấy bởi một ông lão sống một mình trong rừng, ông lão xem đứa bé như là cháu của mình. Một ngày nọ Goku tình cờ gặp một cô gái tên là Bulma trên đường đi bắt cá về, Goku và Bulma đã cùng nhau truy tìm bảy viên ngọc rồng. Bảy viên ngọc rồng chứa đựng một bí mật có thể triệu hồi một con rồng và ban điều ước cho ai sở hữu chúng. Trên cuộc hành trình dài đi tìm bảy viên ngọc rồng, họ gặp những người bạn và những đấu sĩ huyền thoại cũng như nhiều ác quỷ. Hãy cùng đón xem hành trình của họ nhé", "/dragon-ball-bay-vien-ngoc-rong-185177", "", "", 1 },
                    { 48, 48, "Ichigo Kurosaki có khả năng nhìn thấy những hồn ma.<br>Cuộc sống của cậu thay đổi khi cậu gặp Rukia Kuchiki, một Thần Chết và là thành viên của Âm Giới.<br>Khi chiến đấu với một yêu quái chuyên đi săn những người có năng lực tâm linh, Rukia đã cho Ichigo mượn sức mạnh của mình để cậu có thể cứu gia đình mình.Nhưng trước sự ngạc nhiên của Rukia, Ichigo đã hấp thu toàn bộ sức mạnh của cô.<br>Khi đã trở thành một Thần Chết, Ichigo nhanh chóng biết được rằng thế giới cậu đang sống chứa đầy những linh hồn nguy hiểm, và cùng với Rukia, người đang từ từ khôi phục lại sức mạnh của mình.<br>Công việc của Ichigo lúc này là bảo vệ những người vô tội khỏi lũ yêu quái và giúp đỡ những linh hồn tìm được nơi yên nghỉ...", "/than-chet-ichigo-892398", "", "", 1 },
                    { 49, 49, "Kaiden - Một người dùng có khả năng bí ẩn ẩn giấu bên trong cơ thể của một con mèo đường phố. Anh ta sau đó được Jiwoo nhặt lên sau khi bị thương sau một trận chiến với người dùng khả năng khác. Anh ta có một tính cách bướng bỉnh và hách dịch. Jiwoo - một cậu học sinh trung học năng động và hay nói chuyện, yêu mèo. Anh ấy rất tốt bụng và dường như cũng có một khả năng đặc biệt.", "/eleceed-605661", "", "", 1 },
                    { 50, 50, "Mang trong người một cuộc đời bất hạnh, Shin Youngwoo bấy giờ phải xúc đất và bốc gạch tại những công trình xây dựng. Cậu thậm chí phải lao động chân tay trong một trò chơi thực tế ảo có tên là Viên Mãn Giới!<br>Tuy nhiên, vận may du nhập vào cuộc đời vô vọng của Young Woo. Nhân vật Grid của cậu, trong một nhiệm vụ đã phát hiện ra Động Kết Bắc. Trong nơi ấy, Young Woo đã vô tình tìm được 'Bảo Thư của Pagma'. Và đó là ngày đánh dấu cho sự ra đời của một huyền thoại.<br>***<br>Đây chính là câu chuyện về chuyến phiêu lưu của một chàng trai 'vô tài, lắm tật' trên bước đường chinh phục những thành tựu của đời mình.<br>Và hơn thế nữa, đây cũng chính là hành trình của một cậu bé gắt gỏng bất mãn với đời, đứa trẻ ích kỷ chỉ biết nghĩ cho bản thân mình. Trở thành một người đàn ông biết lo lắng, thương yêu và tín nhiệm với mọi người xung quanh.", "/tho-ren-huyen-thoai-900233", "", "", 1 },
                    { 51, 51, "Lucy là một cô gái 17 tuổi, với giấc mơ trở thành một tinh linh pháp sư thực thụ...<br>Rồi một ngày cô đến thị trấn Harujion, cô đã gặp Natsu, một thiếu niên có khả năng sử dụng ma thuật lửa.<br>Nhưng Natsu không phải là một pháp sư thông thường, cậu sử dụng ma thuật cổ đại do một con rồng tên là Igneel dạy dỗ,và là thành viên của một trong số những hội pháp sư nổi tiếng nhất.", "/hoi-phap-su-noi-tieng-738112", "", "", 1 },
                    { 52, 52, "Tên khác: Blue Lock<br>Yoichi Isagi đã bỏ lỡ cơ hội tham dự giải Cao Trung toàn quốc do đã chuyền cho đồng đội thay vì tự thân mình dứt điểm. Cậu là một trong 300 chân sút U-18 được tuyển chọn bởi Jinpachi Ego, người đàn ông được Hiệp Hội Bóng Đá Nhật Bản thuê sau hồi FIFA World Cup năm 2018, nhằm dẫn dắt Nhật Bản vô địch World Cup bằng cách tiêu diệt nền bóng đá Nhật Bản. Kế hoạch của Ego gồm việc cô lập 300 tay sút trong một nhà ngục - dưới một tổ chức với tên gọi là 'Blue Lock', với mục tiêu là tạo ra chân sút 'tự phụ' nhất thế giới, điều mà nền bóng đá Nhật Bản còn thiếu.", "/tien-dao-so-1-513318", "", "", 1 },
                    { 53, 53, "King Grey là người sở hữu tất cả trong một thế giới bị Võ thuật chi phối. Nhưng đi đôi với một sức mạnh to lớn lại là sự cô độc không hồi kết. Thế nên, mặc dù vẻ bên ngoài là một quốc vương mạnh mẽ, nhưng sâu trong thâm tâm lại là một kẻ yếu đuối không có ý chí. Nhưng sau đó lại được tái sinh trong một thế giới fantasy để làm lại một cuộc đời mới. Tuy nhuyên đâu dễ ăn đến thế ? Đằng sau sự hòa bình của thế giới này có vẻ tồn tại một mối đe dọa khủng khiếp nào đó. Với trọng trách lớn lao đó, lý do anh main nhà ta chuyển sinh đến đây là gì ?", "/anh-sang-cuoi-con-duong-488855", "", "", 1 }
                });

            migrationBuilder.InsertData(
                table: "AuthorInDetailComics",
                columns: new[] { "AuthorId", "DetailComicId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 1, 26 },
                    { 1, 27 },
                    { 1, 28 },
                    { 1, 29 },
                    { 1, 30 },
                    { 1, 31 },
                    { 1, 32 },
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 },
                    { 1, 41 },
                    { 1, 42 },
                    { 1, 43 },
                    { 1, 44 },
                    { 1, 45 },
                    { 1, 46 }
                });

            migrationBuilder.InsertData(
                table: "AuthorInDetailComics",
                columns: new[] { "AuthorId", "DetailComicId" },
                values: new object[,]
                {
                    { 1, 47 },
                    { 1, 48 },
                    { 1, 49 },
                    { 1, 50 },
                    { 1, 51 },
                    { 1, 52 },
                    { 1, 53 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "CategoryInDetailComics",
                columns: new[] { "CategoryId", "DetailComicId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 1, 26 },
                    { 1, 27 },
                    { 1, 28 },
                    { 1, 29 },
                    { 1, 30 },
                    { 1, 31 },
                    { 1, 32 }
                });

            migrationBuilder.InsertData(
                table: "CategoryInDetailComics",
                columns: new[] { "CategoryId", "DetailComicId" },
                values: new object[,]
                {
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 },
                    { 1, 41 },
                    { 1, 42 },
                    { 1, 43 },
                    { 1, 44 },
                    { 1, 45 },
                    { 1, 46 },
                    { 1, 47 },
                    { 1, 48 },
                    { 1, 49 },
                    { 1, 50 },
                    { 1, 51 },
                    { 1, 52 },
                    { 1, 53 },
                    { 2, 3 },
                    { 3, 2 },
                    { 8, 4 },
                    { 8, 5 },
                    { 12, 3 },
                    { 12, 4 }
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
                name: "IX_HistoryReadComicOfUsers_ChapterId",
                table: "HistoryReadComicOfUsers",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryReadComicOfUsers_ComicId",
                table: "HistoryReadComicOfUsers",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfComicsUsersFollows_AppUserId",
                table: "ListOfComicsUsersFollows",
                column: "AppUserId");

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
