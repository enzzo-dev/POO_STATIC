using System;
using POO_STATIC.classes;

namespace POO_STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReal(4f));
            Console.WriteLine(Conversor.RealParaDolar(50f));

            //Exemplo de classe Math
            Console.WriteLine(Math.Pow(2,4));

            Pedido p = new Pedido();
            p.Testar();
        }

        void Testar(){

        }
    }
}
