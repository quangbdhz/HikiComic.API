using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comic.Data.Migrations
{
    public partial class db_update_refresh_token : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AppUsers",
                type: "varchar(1000)",
                unicode: false,
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenCreated",
                table: "AppUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenExpires",
                table: "AppUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f0c7b75-8934-4101-bef2-c850e42d21de"),
                column: "ConcurrencyStamp",
                value: "0cf47a45-e26d-468c-9681-391ec7aa0c4e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c489f858-aabd-4264-96c1-5cdca251d871"),
                column: "ConcurrencyStamp",
                value: "9def39ca-43b1-4e82-8370-e00854f694a5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e1db1200-1bb6-4156-9da3-135e91d94aba"),
                column: "ConcurrencyStamp",
                value: "7ea5d646-72f0-483e-badf-412cc4b5f14f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b64f6f0-9f60-45c9-9e7b-f68ccc3fc57f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken" },
                values: new object[] { "0631dc2d-081c-43d3-96aa-fab9e0ee7165", "AQAAAAEAACcQAAAAEOtNKDIOP91MiT2+zvZDGlZD05KahxCFwdygPjOAteG3uOn/CV3n0HFE1HH//FXULg==", "" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "ChapterComics",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRead",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "HistoryReadComicOfUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRead",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateFollow",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "ListOfComicsUsersFollows",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateFollow",
                value: new DateTime(2022, 5, 21, 10, 24, 59, 4, DateTimeKind.Local).AddTicks(3801));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "TokenCreated",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "TokenExpires",
                table: "AppUsers");

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
        }
    }
}
