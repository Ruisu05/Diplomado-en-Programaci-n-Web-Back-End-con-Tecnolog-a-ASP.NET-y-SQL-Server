using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var telefono = new Telefono();
            var smartPhone = new SmartPhone();
            var telPublico = new TelPublico();

            smartPhone.Marca = "";
            smartPhone.Modelo = "";
            smartPhone.SO = "";
            smartPhone.Constestar();
            smartPhone.Colgar();
            smartPhone.Apps();

            telPublico.Marca = "";
            telPublico.Modelo = "";
            telPublico.CapacidadMonedas = 100;
            telPublico.Constestar();
            telPublico.Colgar();
            telPublico.Tiempo();
        }
    }
}
