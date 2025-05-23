using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorProjetosTarefas.Shared.Data.Models;
using GestorProjetosTarefas.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace GestorProjetosTarefas.Shared.Data.BD
{
    public class GestorProjetosTarefasContext : IdentityDbContext<AccessUser, AccessRole, int>
    {
        public DbSet<Empregado> Empregado { get; set; }

        public DbSet<Tarefa> Tarefa { get; set; }

        public DbSet<Projeto> Projeto { get; set; }

        //Conexão Local 
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GestorProjetosTarefas_BD_V1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        //Conexão Azure
        //private string connectionString = "Server=tcp:gestorprojetostarefasserver.database.windows.net,1433;Initial Catalog=GestorProjetosTarefas_BD_V1;Persist Security Info=False;User ID=jose.rodrigues;Password={senha};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empregado>().HasMany(e => e.Projetos).WithMany(p=>p.Empregado);
        }
    }
}
