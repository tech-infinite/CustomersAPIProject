using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomersAPIProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "1 Wall Street", "msmith@gmail.com", "Mike Smith", "0800 750 2219" },
                    { 2, "10 Swiss Cottage Street", "jsmith@gmail.com", "John Hill", "0800 750 2219" },
                    { 3, "15 Logan Road", "tdavis@gmail.com", "Tom Davis", "0800 750 2219" },
                    { 4, "12 Forest Street", "willb@yahoo.com", "Will Brown", "0800 750 2219" },
                    { 5, "20 Fenchurch Road", "jsmith@yahoo.com", "Jess Smith", "0800 750 2219" },
                    { 6, "25 Greenhill Lane", "jnmiills@gmail.com", "Kate Mills", "0800 750 2219" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);
        }
    }
}
