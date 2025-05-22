using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Console
{
    public class Tarefa
    {
        public string Nome {  get; set; }

        public string Descricao { get; set; }

        public Tarefa(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $@"Tarefa: {Nome}";
        }
    }
}
