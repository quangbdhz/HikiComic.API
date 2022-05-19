using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comic.Data.Migrations
{
    public partial class update_data_seed_UrlImageComic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f0c7b75-8934-4101-bef2-c850e42d21de"),
                column: "ConcurrencyStamp",
                value: "06f764cc-6918-48fe-bdbd-af9048edeb02");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c489f858-aabd-4264-96c1-5cdca251d871"),
                column: "ConcurrencyStamp",
                value: "98d59657-b52a-4223-b1b7-f7a48ff6dbce");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e1db1200-1bb6-4156-9da3-135e91d94aba"),
                column: "ConcurrencyStamp",
                value: "676e9dc4-540d-4d36-b43d-0845e1f7d224");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b64f6f0-9f60-45c9-9e7b-f68ccc3fc57f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "026ef0df-5f0b-43bd-8c9a-636bcd3fbcff", "AQAAAAEAACcQAAAAEHPuMzItDI7RuFG+NmXbbnGmIUPiROQ/ajV4pJ28wW0bcctA2b+dnjwAkwB8lq3ABQ==" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRead",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRead",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateFollow",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateFollow",
                value: new DateTime(2022, 5, 10, 8, 49, 7, 965, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.InsertData(
                table: "UrlImageComics",
                columns: new[] { "Id", "ChapterComicId", "IsActive", "UrlImageChapterComic" },
                values: new object[,]
                {
                    { 6, 5, true, "|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png" },
                    { 7, 5, true, "|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png|https://vcomi.co/app/manga/uploads/covers/7de8206eb99958c13cf6f55ba7efbe52.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UrlImageComics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UrlImageComics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f0c7b75-8934-4101-bef2-c850e42d21de"),
                column: "ConcurrencyStamp",
                value: "ed7fae60-7936-4fa5-bfce-d42560eab566");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c489f858-aabd-4264-96c1-5cdca251d871"),
                column: "ConcurrencyStamp",
                value: "6d96c4be-9293-4955-9de9-a768723fcebb");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e1db1200-1bb6-4156-9da3-135e91d94aba"),
                column: "ConcurrencyStamp",
                value: "5872a8ee-61b3-4d63-99ba-e985983f5f96");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b64f6f0-9f60-45c9-9e7b-f68ccc3fc57f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87749f27-d2aa-450a-aec2-87c5d119df22", "AQAAAAEAACcQAAAAEM5jvplmCw811/ZUw4fP52l++yLwPnYxLyCE70XJyXQdJUhl9bgrppf27abZSYp1kw==" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRead",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRead",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateFollow",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateFollow",
                value: new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8145));
        }
    }
}
