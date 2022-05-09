using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comic.Data.Migrations
{
    public partial class db_seend_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImageCategory",
                table: "Categories",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7877), "https://inkr.com/images/explore/action.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7892), "https://inkr.com/images/explore/comedy.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7906), "https://inkr.com/images/explore/comedy.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7907), "https://inkr.com/images/explore/adventure.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7908), "https://inkr.com/images/explore/romance.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7908), "https://inkr.com/images/explore/horror.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7909), "https://inkr.com/images/explore/mature.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7910), "https://inkr.com/images/explore/comedy.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7911), "https://inkr.com/images/explore/manhua.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7912), "https://inkr.com/images/explore/comedy.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7912), "https://inkr.com/images/explore/comedy.svg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "UrlImageCategory" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(7913), "https://inkr.com/images/explore/comedy.svg" });

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
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8002), 11111 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8004), 312 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8006), 5 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8007), 110 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 9, 22, 39, 9, 948, DateTimeKind.Local).AddTicks(8007), 880 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImageCategory",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f0c7b75-8934-4101-bef2-c850e42d21de"),
                column: "ConcurrencyStamp",
                value: "50d93a82-7c3d-4631-bc98-e88b20805686");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c489f858-aabd-4264-96c1-5cdca251d871"),
                column: "ConcurrencyStamp",
                value: "a900d2ac-ac8e-45d0-999c-ca71e41015e9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e1db1200-1bb6-4156-9da3-135e91d94aba"),
                column: "ConcurrencyStamp",
                value: "bfd537a0-599b-4629-a652-527658785bc9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b64f6f0-9f60-45c9-9e7b-f68ccc3fc57f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43a553db-1b9d-4eaa-a7c8-d5c76aea563b", "AQAAAAEAACcQAAAAENER9l60JBakjRHy6QUCUvw2EsNBs1Y8wfExxklEApTKX7Tk4i6D8KCtrYXAQQaxwA==" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6072), 0 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6075), 0 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6076), 0 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6077), 0 });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "ViewCount" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6078), 0 });

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRead",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRead",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateFollow",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateFollow",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6218));
        }
    }
}
