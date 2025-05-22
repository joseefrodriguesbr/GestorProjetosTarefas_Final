using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorProjetosTarefas.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmpregadoProjetoDataEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 1, 1 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 2, 1 });

            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 3, 2 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 4, 2 });

            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 2, 3 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 3, 3 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 4, 3 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 5, 3 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 6, 3 });

            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 1, 4 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 6, 4 });
            migrationBuilder.InsertData("EmpregadoProjeto", new[] { "EmpregadoId", "ProjetosId" }, new Object[] { 7, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
