using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorProjetosTarefas.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Empregado", new[] { "Nome", "Matricula" }, new Object[] { "Maria", "20251" });
            migrationBuilder.InsertData("Empregado", new[] { "Nome", "Matricula" }, new Object[] { "Pedro", "20252" });
            migrationBuilder.InsertData("Empregado", new[] { "Nome", "Matricula" }, new Object[] { "Silvia", "20253" });
            migrationBuilder.InsertData("Empregado", new[] { "Nome", "Matricula" }, new Object[] { "Carol", "20254" });
            migrationBuilder.InsertData("Empregado", new[] { "Nome", "Matricula" }, new Object[] { "Joao", "20255" });
            migrationBuilder.InsertData("Empregado", new[] { "Nome", "Matricula" }, new Object[] { "Monica", "20256" });
            migrationBuilder.InsertData("Empregado", new[] { "Nome", "Matricula" }, new Object[] { "Laura", "20257" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Empregado");
        }
    }
}
