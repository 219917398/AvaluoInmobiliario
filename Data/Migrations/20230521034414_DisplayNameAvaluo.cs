using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaluoInmobiliario.Data.Migrations
{
    /// <inheritdoc />
    public partial class DisplayNameAvaluo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaluos_AvaluoEstatus_EstatusAvaluoId",
                table: "Avaluos");

            migrationBuilder.AlterColumn<int>(
                name: "EstatusAvaluoId",
                table: "Avaluos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaluos_AvaluoEstatus_EstatusAvaluoId",
                table: "Avaluos",
                column: "EstatusAvaluoId",
                principalTable: "AvaluoEstatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaluos_AvaluoEstatus_EstatusAvaluoId",
                table: "Avaluos");

            migrationBuilder.AlterColumn<int>(
                name: "EstatusAvaluoId",
                table: "Avaluos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaluos_AvaluoEstatus_EstatusAvaluoId",
                table: "Avaluos",
                column: "EstatusAvaluoId",
                principalTable: "AvaluoEstatus",
                principalColumn: "Id");
        }
    }
}
