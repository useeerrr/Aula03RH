using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Aula03RH.Models.Enuns;

namespace Aula03RH.Models
{
    public class Funcionario
    {
        public int id { get; set; }
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataAdmissão { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionarioEnum { get; set; }
        public void ReajustarSalário()
        {
            Salario = Salario + (Salario * 10/100);
        }
        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia =
               string.Format("Períodos de Experiência: {0} ate {1}", DataAdmissão, DataAdmissão.AddMonths(3));
               return periodoExperiencia;
        }
        public decimal CalcularDescontoVT(decimal percentual)
        {
            decimal desconto = Salario * percentual/100;
            return desconto;
        }


    }
}