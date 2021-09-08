using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto
            Pessoa pessoa = new Pessoa();

            pessoa.apresentar(); //Apresenta apenas "Olá"
            /*
            pessoa.apresentar("Gabriel"); //Apresenta "Olá + nome"
            pessoa.apresentar("Gabriel", 19); //Apresenta "Olá" + nome + idade
            */

        }
    }
}
