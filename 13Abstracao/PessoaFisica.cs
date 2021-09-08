using System;

class PessoaFisica : Padrao
{
    //Metodo obrigatorio

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("taxa de emprestimo para pessoa fisica R$ " + (valor * 0.1));
    }
}