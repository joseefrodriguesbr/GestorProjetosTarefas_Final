namespace GestorProjetosTarefas_API.Requests
{
    public record TarefaEditRequest(int id, string nome, string descricao, int duracaoDias);
}
