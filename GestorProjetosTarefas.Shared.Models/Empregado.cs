using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProjetosTarefas.Shared.Models
{
    public class Empregado
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Matricula { get; set; }

        public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();

        public virtual ICollection<Projeto> Projetos { get; set; }

        public Empregado(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $@"Id: {Id} , Empregado: {Nome} , Matrícula: {Matricula}";
        }

        public void adicionarTarefas(Tarefa tarefa)
        {
            Tarefas.Add(tarefa);
        }

        public void showTarefas()
        {
            Console.WriteLine($"Tarefas do empregado:{Nome}");
            if (Tarefas.Count > 0)
            {
                foreach (Tarefa tarefa in Tarefas)
                {
                    Console.WriteLine(tarefa);
                }
            }
            else
            {
                Console.WriteLine("Nenhuma tarefa registrada");
            }
        }
    }
}
