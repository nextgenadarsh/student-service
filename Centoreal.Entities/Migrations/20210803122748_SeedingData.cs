using Microsoft.EntityFrameworkCore.Migrations;

namespace Centoreal.Entities.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine", "City", "Country", "State" },
                values: new object[,]
                {
                    { 1, "Professor Colony", "Hyderabad", "India", "Telangana" },
                    { 2, "Kankarbagh", "Patna", "India", "Bihar" },
                    { 3, "Saket Colony", "Delhi", "India", "Delhi" },
                    { 4, "Dream Palace", "Himachal", "India", "Uttarakhand" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Amit Bhadra" },
                    { 2, 2, "Suresh Roy" },
                    { 3, 3, "Kranti Raina" },
                    { 4, 4, "Angelina Singh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
