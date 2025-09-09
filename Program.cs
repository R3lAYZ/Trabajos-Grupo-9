using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 EJERCICIOS-DE-LOS-COLABORADORES
namespace ejem_2

namespace incremento

   main
{
    internal class Program
    {
        static void Main(string[] args)
        {
 EJERCICIOS-DE-LOS-COLABORADORES
            double a, b, c;
            string linea;
            Console.Write("Ingrese cateto 1: ");
            linea = Console.ReadLine();
            a = double.Parse(linea);
            Console.Write("Ingrese cateto 2: ");
            linea = Console.ReadLine();
            b = double.Parse(linea);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine();
            Console.Write("El valor de la hipotenusa es: {0}", c);
            Console.ReadKey();

            int edad;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad <= 17)
            {
                Console.WriteLine("Usted puede acceder al area de pediatria");
            }
            else
            {
                Console.WriteLine("Usted ya no puede acceder al area de pediatria");
            }
 main
        }
    }
}
