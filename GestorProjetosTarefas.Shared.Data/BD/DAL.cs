using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProjetosTarefas.Shared.Data.BD
{
    public class DAL<T> where T : class
     {
        private readonly GestorProjetosTarefasContext context;
        
        // O construtor sem parâmetros tem anomalia de sempre tentar criar um novo registro em projeto, durante a criação de um empregado, mesmo se o projeto já existir.
        //public DAL()
        //{
        //    this.context = new GestorProjetosTarefasContext();
        //}
                
        public DAL(GestorProjetosTarefasContext context) // ← Agora recebe por injeção
        {
            this.context = context;
        }
        public void Create(T value)
        {
            context.Set<T>().Add(value);
            context.SaveChanges();
        }

        public IEnumerable<T> Read()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T value)
        {
            context.Set<T>().Update(value);
            context.SaveChanges();
        }

        public void Delete(T value)
        {
            context.Set<T>().Remove(value);
            context.SaveChanges();
        }

        public T? ReadBy(Func<T, bool> predicate)
        {
            return context.Set<T>().FirstOrDefault(predicate);
        }
    }
}
