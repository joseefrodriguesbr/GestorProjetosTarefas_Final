using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Console
{
    public class Empregado
    {
        public string Nome { get; set; }

        public string Matricula { get; set; }

        private List<Tarefa> Tarefas = new();

        public Empregado(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $@"Empregado: {Nome}";
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
