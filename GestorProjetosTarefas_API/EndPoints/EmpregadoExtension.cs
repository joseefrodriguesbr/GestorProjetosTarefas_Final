using System.Runtime.CompilerServices;
using GestorProjetosTarefas.Shared.Data.BD;
using GestorProjetosTarefas_API.Requests;
using GestorProjetosTarefas.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using GestorProjetosTarefas_API.Responses;

namespace GestorProjetosTarefas_API.Endoints
{
    public static class EmpregadoExtension
    {

        public static void AddEndPointsEmpregado(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("empregado").RequireAuthorization().WithTags("Empregados");

            groupBuilder.MapGet("", ([FromServices] DAL<Empregado> dal) =>
            {
                var empregadoList = dal.Read();
                if (empregadoList == null)return Results.NotFound();

                var empregadoResponseList = EntityListToResponseList(empregadoList);
                
                return Results.Ok(empregadoResponseList);
            }
            );

            groupBuilder.MapGet("/{id}", (int id, [FromServices] DAL<Empregado> dal) =>
            {
                var empregadp = dal.ReadBy(e => e.Id == id);
                if (empregadp is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(empregadp));
            });

            groupBuilder.MapPost("", ([FromServices] DAL<Empregado> dal, [FromServices] DAL<Projeto> projetodal, [FromBody] EmpregadoRequest empregado) =>
            {
                dal.Create(
                   new Empregado(empregado.nome, empregado.matricula)
                   {
                       Projetos = empregado.Projetos is not null ?
                       ProjetoRequestConvert(empregado.Projetos, projetodal) :
                       new List<Projeto>()
                   }
               );
                return Results.Created();
            }
            );

            groupBuilder.MapDelete("/{id}", ([FromServices] DAL<Empregado> dal, int id) =>
            {
                var empregado = dal.ReadBy(e => e.Id == id);
                if (empregado is null)
                {
                    return Results.NotFound();
                }

                dal.Delete(empregado);
                return Results.NoContent();
            }
            );

            groupBuilder.MapPut("", ([FromServices] DAL<Empregado> dal, [FromBody] EmpregadoEditRequest empregado) =>
            {
                var empregadoEdit = dal.ReadBy(e => e.Id == empregado.id);
                if (empregadoEdit is null) return Results.NotFound();

                empregadoEdit.Nome = empregado.nome;
                empregadoEdit.Matricula = empregado.matricula;
                dal.Update(empregadoEdit);
                return Results.Created();
            }
            );

        }

        private static List<Projeto> ProjetoRequestConvert(ICollection<ProjetoRequest> projList, DAL<Projeto> projdal)
        {
            var projetoList = new List<Projeto>();
            foreach (var item in projList)
            {
                var projeto = RequestToEntity(item);
                var projetoBuscado = projdal.ReadBy(p => p.Nome.ToUpper().Equals(projeto.Nome.ToUpper()));
                if (projetoBuscado is not null) projetoList.Add(projetoBuscado);                
                else projetoList.Add(projeto);
            }
            return projetoList;
        }

        private static Projeto RequestToEntity(ProjetoRequest projeto)
        {
            return new Projeto() { Nome = projeto.Nome, Detalhe = projeto.Detalhe, Orcamento = projeto.Orcamento};
        }

        public static ICollection<EmpregadoResponse> EntityListToResponseList(IEnumerable<Empregado> entities)
        {
            return entities.Select(a=>EntityToResponse(a)).ToList();
        }

        private static EmpregadoResponse EntityToResponse(Empregado entity)
        {
            return new EmpregadoResponse(entity.Id,entity.Nome,entity.Matricula);
        }
    }
}
