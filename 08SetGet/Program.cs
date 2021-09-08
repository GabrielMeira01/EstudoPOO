using System;

namespace _08SetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            //p.Nome; ->Get
            p.Nome = "Gabriel"; //Set

            Console.WriteLine(p.Nome);
        }
    }
}
