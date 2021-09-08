using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = "Gabriel";

            pessoa.idade = 19;

            pessoa.mensagem();
        }
    }
}
