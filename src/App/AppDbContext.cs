using Microsoft.EntityFrameworkCore;

namespace SimpleCrudExample
{
    public class AppDbContext
    {
        public class Tarefa
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public bool Concluida { get; set; }
        }

        public class ApplicationContext : DbContext
        {
            public DbSet<Tarefa> Tarefas { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                //String de conexão com o banco de dados
                optionsBuilder.UseSqlite("Data Source=tarefas.db");
            }
        }
    }
}
