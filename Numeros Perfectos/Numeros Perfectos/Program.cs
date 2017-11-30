using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Perfecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int Y;

            Console.WriteLine("Ingrese el número que desea saber si es perfecto: ");
            Y = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i < Y; i++)
            {
                if (Y % i == 0)
                {
                    X = X + i;
                }
            }

            if (X == Y)
            {
                Console.WriteLine("El " + Y + " es un número perfecto");
            }

            else
            {
                Console.WriteLine("El " + Y + " no es un número perfecto");
            }
        }
    }
}
