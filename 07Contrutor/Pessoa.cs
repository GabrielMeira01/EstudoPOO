using System;

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Contrutor executado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá " + nome);
    }
}