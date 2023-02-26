using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_que_imprime_niño__joven_y_adulto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese tu edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 13)
            {
                Console.WriteLine("Eres un niño");

            }

            else if (edad <= 25)
            {
                Console.WriteLine("Eres joven");
            }

            else
            {
                Console.WriteLine("Eres un adulto");
            }

            Console.ReadKey();
        }
    }
}
