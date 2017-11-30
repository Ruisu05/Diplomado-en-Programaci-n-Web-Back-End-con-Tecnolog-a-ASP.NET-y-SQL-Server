using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares
{
    class NPares
    {
        public int x;
        public void NumPares()
        {
            x = 0;
            Console.WriteLine("Pares del 1 al 100.");
            while (x < 100)
            {
                x = x + 2;
                Console.WriteLine(x);
            }
        }
    }
}
