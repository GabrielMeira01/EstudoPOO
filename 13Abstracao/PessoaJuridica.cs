using System;

class PessoaJuridica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para pessoa juridica R$ " + (valor * 0.2));
    }
}