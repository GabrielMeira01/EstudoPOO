using System;

class Pessoa
{
    public double peso, altura;

    //Metodos
    public double calculaIMC()
    {
        //double calculoIMC = (altura * altura) / peso ;

        return peso / (altura * altura);
    }

    public string grauIMC(double IMC)
    {
        string retorno;

        if(IMC < 18.5)
        {
            retorno = "abaixo do peso";
        }
        else if(IMC < 25)
        {
            retorno = "peso normal";
        }
        else if(IMC < 30)
        {
            retorno = "acima do peso";
        }
        else if(IMC < 35)
        {
            retorno = "obesidade I";
        }
        else if(IMC < 40)
        {
            retorno = "obesidade II";
        }
        else if(IMC > 40)
        {
            retorno = "obesidade III";
        }
        else
        {
            retorno = "obesidade III";
        }

        return retorno;
    }

    public void mensagem()
    {
        double obtemIMC = calculaIMC();
        string obtemGrauIMC = grauIMC(obtemIMC);

        Console.WriteLine("Seu IMC é de " + obtemIMC);
        Console.WriteLine("Sua situação é  " + obtemGrauIMC);
    }
}
