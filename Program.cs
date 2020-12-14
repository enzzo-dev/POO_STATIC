using System;
using POO_STATIC.classes;

namespace POO_STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReal(4f));
            System.Console.WriteLine("---------------------------------------");
            Console.WriteLine(Conversor.RealParaDolar(50f));
            System.Console.WriteLine("---------------------------------------");
            Console.WriteLine(Conversor.EuroParaReal(30f));
            System.Console.WriteLine("---------------------------------------");
            Console.WriteLine(Conversor.RealParaEuro(54f));
            System.Console.WriteLine("---------------------------------------");

            //Exemplo de classe Math
            Console.WriteLine(Math.Pow(2,4));
            System.Console.WriteLine("---------------------------------------");

            Pedido p = new Pedido();
            p.Testar();
            System.Console.WriteLine("---------------------------------------");
        }

        void Testar(){

        }
    }
}
