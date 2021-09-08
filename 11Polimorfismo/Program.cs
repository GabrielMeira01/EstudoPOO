using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia estagiario
            Imposto objtetoE = new Estagiario();
            objtetoE.valeAlimentacao(1000);
            objtetoE.valeTransporte(1000);
            Console.WriteLine("---------------------");

            //Instancia gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            Console.WriteLine("---------------------");

            //Instacia atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
            Console.WriteLine("---------------------");

        }
    }
}
