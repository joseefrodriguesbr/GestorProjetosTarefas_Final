namespace GestorProjetosTarefas_API.Requests
{
    public record ProjetoEditRequest(int id, string nome, string detalhe, double orcamento);
}
