using System.Data.Entity;

namespace ContrachequeOnline.Models
{
    public class ContrachequeContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Contracheque> Contracheques { get; set; }
    }
}
