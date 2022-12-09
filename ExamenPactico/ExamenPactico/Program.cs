using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPactico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Limite;
            Console.WriteLine("Ingrese un numero limite para realizar la serie de Fibonacci");
            Limite =int.Parse( Console.ReadLine());
            Console.WriteLine("**************************");
            int resul=1;
            for (int i = 0; i < Limite; i++)
            {
                
                
            
                Console.WriteLine(resul);

            }

        }
    }
}
