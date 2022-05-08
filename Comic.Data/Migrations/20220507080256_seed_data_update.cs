using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comic.Data.Migrations
{
    public partial class seed_data_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ChapterComics",
                columns: new[] { "Id", "ComicId", "DateCreated", "IsActive", "NameChapter", "SeoAlias" },
                values: new object[,]
                {
                    { 8, 3, new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6174), true, "Chapter 1", "/khong-minh-thich-tiec-tung-813713/chapter-1-204813" },
                    { 9, 4, new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6174), true, "Chapter 1", "/anh-hung-tro-lai-590960/chapter-1-947274" }
                });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 55, 636, DateTimeKind.Local).AddTicks(6078));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f0c7b75-8934-4101-bef2-c850e42d21de"),
                column: "ConcurrencyStamp",
                value: "ebef4536-12b2-4f80-9ea3-08d5310e4c96");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c489f858-aabd-4264-96c1-5cdca251d871"),
                column: "ConcurrencyStamp",
                value: "94856da1-bccf-4229-86fc-15fc39075afe");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e1db1200-1bb6-4156-9da3-135e91d94aba"),
                column: "ConcurrencyStamp",
                value: "e2d3b151-a708-4110-bf7f-79a28825239b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b64f6f0-9f60-45c9-9e7b-f68ccc3fc57f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e74f177f-635d-45ff-9cdc-269f3af30633", "AQAAAAEAACcQAAAAEJES+ys/OkvgxbyArZXR/gyjKdFx4OzZWcZaC/PhA9f8JSeiudJVHkh722QP4t+ljg==" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRead",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRead",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateFollow",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateFollow",
                value: new DateTime(2022, 5, 7, 14, 4, 56, 104, DateTimeKind.Local).AddTicks(7721));
        }
    }
}
