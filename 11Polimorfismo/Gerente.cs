using System;

class Gerente : Imposto
{
    //Metodo

    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Descontro gerente do vale alimentação R$ " + (salario * 0.15));
    }
}