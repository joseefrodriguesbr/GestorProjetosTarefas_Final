using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorProjetosTarefas.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelateEmpregadoTarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpregadoId",
                table: "Tarefa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_EmpregadoId",
                table: "Tarefa",
                column: "EmpregadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Empregado_EmpregadoId",
                table: "Tarefa",
                column: "EmpregadoId",
                principalTable: "Empregado",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Empregado_EmpregadoId",
                table: "Tarefa");

            migrationBuilder.DropIndex(
                name: "IX_Tarefa_EmpregadoId",
                table: "Tarefa");

            migrationBuilder.DropColumn(
                name: "EmpregadoId",
                table: "Tarefa");
        }
    }
}
