using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_numeros_pares_e_inpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;

            Console.WriteLine("Ingresar Numero: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            if (num % 5 == 0)
            {
                Console.WriteLine("El numero es par", num);
            }
            else
            {
                Console.WriteLine("El numero es impar", num);
            }
            Console.ReadKey();

        }
    }
}
