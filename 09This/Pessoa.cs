using System;

class Pessoa
{
    //Atributo

    private string nome = "Tatiana";

    //Contrutor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); //Pega o atributo 
    }
}