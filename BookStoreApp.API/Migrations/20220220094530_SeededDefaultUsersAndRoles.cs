using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60330124-9230-11ec-b909-0242ac120002", "1630bc5b-3ffd-4d7b-811f-2e4d84012b71", "User", "USER" },
                    { "91f35e66-9230-11ec-b909-0242ac120002", "1dc3c987-f154-44aa-be9a-401979cc9001", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f5a266a0-9230-11ec-b909-0242ac120002", 0, "95b6df47-f958-407d-91c3-535f45b190d2", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAED5ljxJXYzn0UybBBiog6/wTmaDsYeLTbMWpwbswspDr7XM/MuoG0zqomIQ6MT7xng==", null, false, "8c8d8931-3b46-41a9-be91-4dde392bb232", false, "admin@bookstore.com" },
                    { "fa60ce98-9230-11ec-b909-0242ac120002", 0, "94959fe4-0942-4c68-8e31-1328a0b1f7fb", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEIx+yx8Jaz61syZp+4P5TcOUYt40mOlRti1Of3ayRvp8fK8ZUKLvMqeugX/4o5wNRA==", null, false, "c55d0882-cc7d-4991-b547-c8dc749a6b93", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91f35e66-9230-11ec-b909-0242ac120002", "f5a266a0-9230-11ec-b909-0242ac120002" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "60330124-9230-11ec-b909-0242ac120002", "fa60ce98-9230-11ec-b909-0242ac120002" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91f35e66-9230-11ec-b909-0242ac120002", "f5a266a0-9230-11ec-b909-0242ac120002" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60330124-9230-11ec-b909-0242ac120002", "fa60ce98-9230-11ec-b909-0242ac120002" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60330124-9230-11ec-b909-0242ac120002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91f35e66-9230-11ec-b909-0242ac120002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5a266a0-9230-11ec-b909-0242ac120002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa60ce98-9230-11ec-b909-0242ac120002");
        }
    }
}
