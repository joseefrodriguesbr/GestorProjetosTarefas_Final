using GestorProjetosTarefas.Shared.Models;

namespace GestorProjetosTarefas_API.Requests
{
    public record EmpregadoRequest(string nome, string matricula, ICollection<ProjetoRequest> Projetos = null);
}
