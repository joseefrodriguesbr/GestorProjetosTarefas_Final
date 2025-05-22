using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorProjetosTarefas.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelateEmpregadoProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projeto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detalhe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orcamento = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpregadoProjeto",
                columns: table => new
                {
                    EmpregadoId = table.Column<int>(type: "int", nullable: false),
                    ProjetosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpregadoProjeto", x => new { x.EmpregadoId, x.ProjetosId });
                    table.ForeignKey(
                        name: "FK_EmpregadoProjeto_Empregado_EmpregadoId",
                        column: x => x.EmpregadoId,
                        principalTable: "Empregado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpregadoProjeto_Projeto_ProjetosId",
                        column: x => x.ProjetosId,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoProjeto_ProjetosId",
                table: "EmpregadoProjeto",
                column: "ProjetosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpregadoProjeto");

            migrationBuilder.DropTable(
                name: "Projeto");
        }
    }
}
