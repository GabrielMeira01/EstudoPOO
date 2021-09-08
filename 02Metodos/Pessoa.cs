using System;

class Pessoa // Toda classe começa com letra maiuscula
{
    //Metodos podem ter o mesmo nome mas com parametros diferentes
    //Metodo 01
    public void apresentar()
    {
        Console.WriteLine("Olá!!!");
    
    }

    //Metodo 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá " + nome);
    }

    //Metodo 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá" + nome + " Você tem " + idade + "anos"); 
    }
}