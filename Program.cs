using System;
using Aula03RH.Models;

namespace Aula03RH
{
     public class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            func.id = 10;
            func.Nome = "Neymar";
            func.Cpf = "12345678910";
            func.DataAdmissão = DateTime.Parse("03/03/2026");
            func.Salario = 1000.00M;
            func.TipoFuncionarioEnum = Models.Enuns.TipoFuncionarioEnum.CLT;
            
            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine(mensagem);
        }
    }
}
