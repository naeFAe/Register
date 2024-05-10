using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Register.Migrations
{
    /// <inheritdoc />
    public partial class fae2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c8014b7-279e-4f8c-bbc2-bf21f41fc8d6", null, "seller", "seller" },
                    { "c1d0e761-8865-4b5e-bc94-f119be098291", null, "client", "client" },
                    { "df8f9911-7f4e-4e26-bb98-ff131ce2c247", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c8014b7-279e-4f8c-bbc2-bf21f41fc8d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1d0e761-8865-4b5e-bc94-f119be098291");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df8f9911-7f4e-4e26-bb98-ff131ce2c247");
        }
    }
}
