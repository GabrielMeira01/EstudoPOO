using System;

namespace _13Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
           PessoaFisica PF = new PessoaFisica();

           PF.taxaEmprestimo(1000);

            PessoaJuridica PJ = new PessoaJuridica();

            PJ.taxaEmprestimo(1000);
        }
    }
}
