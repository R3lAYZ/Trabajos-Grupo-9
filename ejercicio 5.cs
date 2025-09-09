using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
