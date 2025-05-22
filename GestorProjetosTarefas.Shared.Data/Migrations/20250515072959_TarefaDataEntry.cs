using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorProjetosTarefas.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class TarefaDataEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "Programação", "Progamacao do backend", 5, 1 });
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "Repositório", "Configuracao do repositório GIT", 2, 1 });
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "Banco de Dados", "Projeto de ER do Banco de Dados", 1, 2 });
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "GUI", "Interface gráfica", 10, 3 });
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "Documentação", "Manuais do usuário", 4, 4 });
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "Levantamento de requisitos", "Elaboração de projeto com o cliente", 7, 4 });
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "DevOps", "Criação de infraestrutura DevOps", 1, 4 });
            migrationBuilder.InsertData("Tarefa", new[] { "Nome", "Descricao", "DuracaoDias", "EmpregadoId" }, new Object[] { "IA", "Agentes de IA", 12, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
