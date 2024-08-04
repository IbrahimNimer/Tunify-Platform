using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TunifyPlatform.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "Bio", "Name" },
                values: new object[] { 1, "Artist Bio", "Artist Name" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UsersId", "Email", "Join_Date", "Subscription_ID", "Username" },
                values: new object[] { 1, "ibrahim@gmail.com", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ibrahim Nimer" });

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "PlaylistId", "Created_Date", "Playlist_Name", "UsersId" },
                values: new object[] { 1, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fav", 1 });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "ArtistId", "Title" },
                values: new object[] { 1, 1, "Some One Like You" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UsersId",
                keyValue: 1);
        }
    }
}
