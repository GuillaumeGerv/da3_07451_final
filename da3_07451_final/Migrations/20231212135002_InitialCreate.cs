using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace da3_07451_final.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acteur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(48)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(48)", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Anne = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActeurFilm",
                columns: table => new
                {
                    ActeursId = table.Column<int>(type: "int", nullable: false),
                    FilmsId = table.Column<int>(type: "int", nullable: false),
                    ActeursDTOId = table.Column<int>(type: "int", nullable: false),
                    FilmsDTOId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActeurFilm", x => new { x.ActeursId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_ActeurFilm_Acteur_ActeursDTOId",
                        column: x => x.ActeursDTOId,
                        principalTable: "Acteur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActeurFilm_Films_FilmsDTOId",
                        column: x => x.FilmsDTOId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acteur",
                columns: new[] { "Id", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "Freeman", "Morgan" },
                    { 2, "Damon", "Matte" },
                    { 3, "Robbins", "Tim" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Anne", "Title" },
                values: new object[,]
                {
                    { 1, 1994, "The Shawshank Redemption" },
                    { 2, 2008, "Invictus" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActeurFilm_ActeursDTOId",
                table: "ActeurFilm",
                column: "ActeursDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_ActeurFilm_FilmsDTOId",
                table: "ActeurFilm",
                column: "FilmsDTOId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActeurFilm");

            migrationBuilder.DropTable(
                name: "Acteur");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
