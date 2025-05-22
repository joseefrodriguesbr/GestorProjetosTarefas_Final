using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorProjetosTarefas.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProjetoDataEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Projeto", new[] { "Nome", "Detalhe", "Orcamento" }, new Object[] { "Protocolo Eletrônico", "Sistema Protocolo Eletrônico", 10000 });
            migrationBuilder.InsertData("Projeto", new[] { "Nome", "Detalhe", "Orcamento" }, new Object[] { "Site Institucional", "Site Institucional da Inatel", 8000 });
            migrationBuilder.InsertData("Projeto", new[] { "Nome", "Detalhe", "Orcamento" }, new Object[] { "Governo Digital", "Sistema de Governança Estadual", 85030 });
            migrationBuilder.InsertData("Projeto", new[] { "Nome", "Detalhe", "Orcamento" }, new Object[] { "Sistema Vestibular", "Sistema para Gerenciamento de inscrições", 5850 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
