using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketApp.Migrations
{
    public partial class editTicketdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DateOfBirth", "EmailAddress", "Gender", "UserName", "UserTypeId" },
                values: new object[] { 2, new DateTime(1998, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "anas@ticket.com", "male", "anas", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DateOfBirth", "EmailAddress", "Gender", "UserName", "UserTypeId" },
                values: new object[] { 3, new DateTime(1996, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmad@ticket.com", "male", "ahmad", 2 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "ID", "Description", "DestinationLocation", "ExpDate", "Name", "StartingLocation", "TravelDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Work Travel(conference in istanbul)", "Istanbul", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work", "Queen Alia", new DateTime(2020, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, "Recreation Travel", "Ankara", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recreation", "Queen Alia", new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Work Travel", "Cairo", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "work", "Queen Alia", new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "Discover Travel", "Moroco", new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "History", "Queen Alia", new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
