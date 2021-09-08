using System;

class Colaborador : Pessoa //Não existe herança multipla em c#
{
    //Atributos
    private double salario;

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    //Metodo
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: " + salario);
    }
}