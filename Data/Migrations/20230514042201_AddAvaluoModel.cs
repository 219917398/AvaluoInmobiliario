using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaluoInmobiliario.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAvaluoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvaluoEstatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaluoEstatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avaluos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAvaluo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    Valuador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solicitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropietarioInmueble = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropositoAvaluo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstatusAvaluoId = table.Column<int>(type: "int", nullable: true),
                    TipoPropiedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumExterior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumInterior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conjunto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelegacionMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClasifZona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefProxUrbana = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstruccionesPredom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndiceSaturacion = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DensidadPoblacion = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NivelSocioeconomico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViasAcceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntensidadFlujoVehicular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfraestructuraDisponible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiciosBasicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtrosServicios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipamientoUrbano = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComentariosEntorno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallesLimOrientacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensiones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colindancia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Configuracion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Topografia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsoSuelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DensidadHabitacional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UbicacionLoteCalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Restricciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Giro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumNiveles = table.Column<int>(type: "int", nullable: true),
                    SuperficiesCubiertas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreasAccesorias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficieVendible = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ClaseGeneralInmueble = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoConservacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdadConstrucciones = table.Column<int>(type: "int", nullable: true),
                    VidaUtilRemanente = table.Column<int>(type: "int", nullable: true),
                    Cimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperEstructura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Muros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Escaleras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LosasEntrepisos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LosasAzoteas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstalacionesEspeciales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementosAccesorios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObrasComplementarias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pisos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Muros2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plafones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstalacionesHidraulicas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstalacionesSanitarias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstalacionesElectricas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puertas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Closets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MueblesFijos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pisos2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ventanas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vidrieria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cerrajeria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeterminacionValor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaluos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaluos_AvaluoEstatus_EstatusAvaluoId",
                        column: x => x.EstatusAvaluoId,
                        principalTable: "AvaluoEstatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AvaluoArchivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvaluoId = table.Column<int>(type: "int", nullable: true),
                    NombreArchivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoArchivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Archivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaluoArchivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaluoArchivos_Avaluos_AvaluoId",
                        column: x => x.AvaluoId,
                        principalTable: "Avaluos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvaluoArchivos_AvaluoId",
                table: "AvaluoArchivos",
                column: "AvaluoId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaluos_EstatusAvaluoId",
                table: "Avaluos",
                column: "EstatusAvaluoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaluoArchivos");

            migrationBuilder.DropTable(
                name: "Avaluos");

            migrationBuilder.DropTable(
                name: "AvaluoEstatus");
        }
    }
}
