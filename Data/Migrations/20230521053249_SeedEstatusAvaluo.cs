using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AvaluoInmobiliario.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedEstatusAvaluo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AvaluoEstatus",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Nuevo" },
                    { 2, "En proceso" },
                    { 3, "Completado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvaluoEstatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvaluoEstatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvaluoEstatus",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
