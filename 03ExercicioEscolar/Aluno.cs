using System;


class Aluno
{
    public string nome;
    public double nota1, nota2;

    //Metodos

    //Media
    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    public void mensagem()
    {
        //obter media

        double obtermedia = media();

        //obter situacao
        string obtersituacao = situacao(obtermedia);

        Console.WriteLine(nome + " esta " + obtersituacao + " com média " + obtermedia);
    }
}