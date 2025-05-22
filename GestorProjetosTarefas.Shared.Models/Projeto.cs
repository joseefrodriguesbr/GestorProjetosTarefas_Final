using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProjetosTarefas.Shared.Models
{
    public class Projeto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Detalhe { get; set; }

        public double Orcamento { get; set; }

        public virtual ICollection<Empregado> Empregado { get; set; }

        public override string ToString()
        {
            return $@"Id: {Id} , Nome: {Nome} , Detalhe: {Detalhe}, Orcamento: {Orcamento}";
        }

    }
}
