using System;

namespace ContrachequeOnline.Models
{
    public class Contracheque
    {
        public int ContrachequeId { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal Salario { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal ValorHorasExtras { get; set; }
        public decimal AdicionalNoturno { get; set; }
        public decimal AdicionalInsalubridade { get; set; }
        public decimal AdicionalPericulosidade { get; set; }
        public decimal Comissoes { get; set; }
        public decimal BonusGratificacoes { get; set; }
        public decimal PLR { get; set; }
        public decimal AjudaCusto { get; set; }
        public decimal ValeTransporte { get; set; }
        public decimal ValeRefeicao { get; set; }
        public decimal PlanoSaudeEmpregador { get; set; }
        public decimal PlanoOdontologicoEmpregador { get; set; }
        public decimal SeguroVida { get; set; }
        public decimal AuxilioCreche { get; set; }
        public decimal AuxilioEducacao { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
