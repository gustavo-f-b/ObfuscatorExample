using static SimpleCrudExample.AppDbContext;

InicializarBancoDeDados();

AdicionarTarefa("Estudar C#");
ListarTarefas();

static void AdicionarTarefa(string nome)
{
    using var db = new ApplicationContext();
    db.Tarefas.Add(new Tarefa { Nome = nome });
    db.SaveChanges();
}

static void ListarTarefas()
{
    using var db = new ApplicationContext();
    var tarefas = db.Tarefas.ToList();
    foreach (var tarefa in tarefas)
    {
        Console.WriteLine($"{tarefa.Id}: {tarefa.Nome} - Concluída: {tarefa.Concluida}");
    }
}
static void InicializarBancoDeDados()
{
    using var contexto = new ApplicationContext();

    contexto.Database.EnsureCreated();
}