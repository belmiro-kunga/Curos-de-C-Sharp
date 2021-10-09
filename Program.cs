using System;

namespace Curos_de_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine("Hello World!");
           Kunga(-19);
             Kunga(1);
               Kunga(15);
                 Kunga(30);
        }

        static void Kunga(int preco){

            int precoaAbs =  Math.Abs(preco);
            int precoFinal =  precoaAbs + (2 * precoaAbs);
            Console.WriteLine("O Preço final é de: " + precoFinal);

        } 

    }
}
