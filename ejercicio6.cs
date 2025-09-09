using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jercicio_mayor_igual
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double estatura;

            Console.Write("Ingrese su estatura en cm: ");
            estatura = double.Parse(Console.ReadLine());

            if (estatura >= 1.50)
            {
                Console.WriteLine("Puedes ingresar al juego");
            }
            else
            {
                Console.WriteLine("No puedes ingresar");
            }

        }
    }
}
