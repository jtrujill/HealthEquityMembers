using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthEquityMembers.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1L, "jeremytru91@gmail.com", "Jeremy", "Trujillo", "801-882-1432" },
                    { 2L, "bob_someone@gmail.com", "Bob", "Someone", "801-111-1111" },
                    { 3L, "jane_doe@gmail.com", "jane", "doe", "801-222-2222" },
                    { 4L, "test_user@gmail.com", "test", "user", "801-333-3333" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L);
        }
    }
}
