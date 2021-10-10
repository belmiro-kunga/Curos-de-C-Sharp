using System;

namespace Curos_de_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //# Sobrecarga de método / Funçoes

            int mynum1 = FuncaoInt(5, 7);
            double mynum2 = FuncaoInt(4.2, 7.3);

            Console.WriteLine("int " + mynum1);
            Console.WriteLine("double " + mynum2);

            
        }

        static int FuncaoInt(int x, int y){
            return x + y;
        }


        static double FuncaoInt(double x, double y){
            return x + y;
        }
    }
}
