using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Telefono
    {
        public string Marca;
        public string Modelo;

        public void Marcar()
        {

        }

        public void Constestar()
        {

        }

        public void Colgar()
        {

        }
    }

    class SmartPhone : Telefono
    {
        public string SO;

        public void Apps()
        {
            Console.WriteLine("WhatsApp iniciado.");
            Console.WriteLine("Facebook iniciado.");
        }
    }

    class TelPublico : Telefono
    {
        public int CapacidadMonedas;

        public void Tiempo()
        {
            Console.WriteLine("Saldo agotado");
        }
    }
}
}
