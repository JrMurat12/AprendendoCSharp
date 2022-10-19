using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitasSKA.Migrations
{
    public partial class CreateTableReceita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoReceita = table.Column<int>(type: "int", nullable: false),
                    VersaoPeso = table.Column<float>(type: "real", nullable: false),
                    LotePadrao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoPadrao = table.Column<float>(type: "real", nullable: false),
                    CodigoCT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociacaoReceita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceitaId = table.Column<int>(type: "int", nullable: false),
                    CodigoRecurso = table.Column<int>(type: "int", nullable: false),
                    LotePadrao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoPadrao = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociacaoReceita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssociacaoReceita_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociacaoReceita_ReceitaId",
                table: "AssociacaoReceita",
                column: "ReceitaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociacaoReceita");

            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
