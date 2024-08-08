using System.Collections.Generic;

namespace ContrachequeOnline.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<Contracheque> Contracheques { get; set; }
    }
}
