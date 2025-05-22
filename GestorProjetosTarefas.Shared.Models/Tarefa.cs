using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProjetosTarefas.Shared.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Nome {  get; set; }

        public string Descricao { get; set; }

        public int DuracaoDias { get; set; }

        public virtual Empregado? Empregado { get; set; }

        public Tarefa(string nome, string descricao, int duracaoDias)
        {
            Nome = nome;
            Descricao = descricao;
            DuracaoDias = duracaoDias;
        }

        public override string ToString()
        {
            return $@"Id: {Id} ,Tarefa: {Nome} , descricao: {Descricao} , duração em dias: {DuracaoDias}";
        }
    }
}
