using System;

class Aluno
{
    //Atributos

    private double nota1, nota2;

    //Media
    private double media()
    {
        double calculaMedia = (nota1 + nota2) / 2;
        return calculaMedia;
    }

    //Mensagem
    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A média é " + media());
    }
}