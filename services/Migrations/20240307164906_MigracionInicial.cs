using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace services.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    nIdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nIdTipoDocumento = table.Column<int>(type: "int", nullable: false),
                    sDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sApellidoP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sApellidoM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dFechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nIdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.nIdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    nIdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sGenero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.nIdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    nIdSala = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sSala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nCapacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.nIdSala);
                });

            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    nIdPelicula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sTitulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sSinopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tDuracion = table.Column<TimeSpan>(type: "time", nullable: false),
                    bPortada = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    nIdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.nIdPelicula);
                    table.ForeignKey(
                        name: "FK_Pelicula_Genero_nIdGenero",
                        column: x => x.nIdGenero,
                        principalTable: "Genero",
                        principalColumn: "nIdGenero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaPelicula",
                columns: table => new
                {
                    nIdSalaPelicula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nIdSala = table.Column<int>(type: "int", nullable: false),
                    nIdPelicula = table.Column<int>(type: "int", nullable: false),
                    dFechaProgramada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaPelicula", x => x.nIdSalaPelicula);
                    table.ForeignKey(
                        name: "FK_SalaPelicula_Pelicula_nIdPelicula",
                        column: x => x.nIdPelicula,
                        principalTable: "Pelicula",
                        principalColumn: "nIdPelicula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalaPelicula_Sala_nIdSala",
                        column: x => x.nIdSala,
                        principalTable: "Sala",
                        principalColumn: "nIdSala",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    nIdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nIdCliente = table.Column<int>(type: "int", nullable: false),
                    nIdSalaPelicula = table.Column<int>(type: "int", nullable: false),
                    nCantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.nIdReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente_nIdCliente",
                        column: x => x.nIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "nIdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_SalaPelicula_nIdSalaPelicula",
                        column: x => x.nIdSalaPelicula,
                        principalTable: "SalaPelicula",
                        principalColumn: "nIdSalaPelicula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "nIdGenero", "sGenero" },
                values: new object[,]
                {
                    { 1, "Acción" },
                    { 2, "Terror" },
                    { 3, "Comedia" }
                });

            migrationBuilder.InsertData(
                table: "Sala",
                columns: new[] { "nIdSala", "nCapacidad", "sSala" },
                values: new object[,]
                {
                    { 1, 100, "A" },
                    { 2, 100, "B" },
                    { 3, 100, "C" },
                    { 4, 100, "D" }
                });

            migrationBuilder.InsertData(
                table: "Pelicula",
                columns: new[] { "nIdPelicula", "bPortada", "nIdGenero", "sSinopsis", "sTitulo", "tDuracion" },
                values: new object[,]
                {
                    { 1, null, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Terminator", new TimeSpan(0, 1, 30, 0, 0) },
                    { 2, null, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Duro de Matar", new TimeSpan(0, 1, 45, 0, 0) },
                    { 3, null, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Saw I", new TimeSpan(0, 2, 0, 0, 0) },
                    { 4, null, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "La Monja", new TimeSpan(0, 1, 40, 0, 0) },
                    { 5, null, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Donde están las tubias", new TimeSpan(0, 1, 45, 0, 0) },
                    { 6, null, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "El todo poderoso", new TimeSpan(0, 1, 35, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "SalaPelicula",
                columns: new[] { "nIdSalaPelicula", "dFechaProgramada", "nIdPelicula", "nIdSala" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, new DateTime(2024, 3, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 4, new DateTime(2024, 3, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 5, new DateTime(2024, 3, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 6, new DateTime(2024, 3, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 7, new DateTime(2024, 3, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 8, new DateTime(2024, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 9, new DateTime(2024, 3, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 10, new DateTime(2024, 3, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 11, new DateTime(2024, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 12, new DateTime(2024, 3, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 13, new DateTime(2024, 3, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 14, new DateTime(2024, 3, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 15, new DateTime(2024, 3, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 16, new DateTime(2024, 3, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 17, new DateTime(2024, 3, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 18, new DateTime(2024, 3, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 19, new DateTime(2024, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 20, new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 21, new DateTime(2024, 3, 11, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 22, new DateTime(2024, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 23, new DateTime(2024, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 24, new DateTime(2024, 3, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pelicula_nIdGenero",
                table: "Pelicula",
                column: "nIdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_nIdCliente",
                table: "Reserva",
                column: "nIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_nIdSalaPelicula",
                table: "Reserva",
                column: "nIdSalaPelicula");

            migrationBuilder.CreateIndex(
                name: "IX_SalaPelicula_nIdPelicula",
                table: "SalaPelicula",
                column: "nIdPelicula");

            migrationBuilder.CreateIndex(
                name: "IX_SalaPelicula_nIdSala",
                table: "SalaPelicula",
                column: "nIdSala");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "SalaPelicula");

            migrationBuilder.DropTable(
                name: "Pelicula");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropTable(
                name: "Genero");
        }
    }
}
