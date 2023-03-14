using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class dbseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "MinimalistBoilerPlate",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdSoyad", "Adres", "EPosta", "Yas" },
                values: new object[] { " Mustafa Kupik", "Minimalist Boiler Plate by null. tech", "null@tech.com", "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "MinimalistBoilerPlate",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdSoyad", "Adres", "EPosta", "Yas" },
                values: new object[] { " Selda Bağcan", "Konak mah. 312. Cd. 123. sk İzmir Türkiye", "vurucusesselda@yahoo.com", "64" });
        }
    }
}
