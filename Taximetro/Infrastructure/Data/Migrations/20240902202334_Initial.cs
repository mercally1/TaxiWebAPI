using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conductores",
                columns: table => new
                {
                    ConductorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Licencia = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Contacto = table.Column<int>(type: "int", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conductores", x => x.ConductorId);
                });

            migrationBuilder.CreateTable(
                name: "taxis",
                columns: table => new
                {
                    TaxiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConductorId = table.Column<int>(type: "int", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ahno = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taxis", x => x.TaxiId);
                    table.ForeignKey(
                        name: "FK_taxis_conductores_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "conductores",
                        principalColumn: "ConductorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trayectos",
                columns: table => new
                {
                    TrayectoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ubicacion_Initial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ubicacion_Final = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxiId = table.Column<int>(type: "int", nullable: false),
                    Kilometraje = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trayectos", x => x.TrayectoId);
                    table.ForeignKey(
                        name: "FK_trayectos_taxis_TaxiId",
                        column: x => x.TaxiId,
                        principalTable: "taxis",
                        principalColumn: "TaxiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_taxis_ConductorId",
                table: "taxis",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_trayectos_TaxiId",
                table: "trayectos",
                column: "TaxiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trayectos");

            migrationBuilder.DropTable(
                name: "taxis");

            migrationBuilder.DropTable(
                name: "conductores");
        }
    }
}
