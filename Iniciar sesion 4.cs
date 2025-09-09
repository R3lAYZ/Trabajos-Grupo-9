using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contraseña_de_ingreso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIAR SESION");
            Console.Write("Ingrese la Contraseña: ");
            string Contraseña = Console.ReadLine();

            if (Contraseña != "54233")
            {
                Console.WriteLine("Acceso Denegado");
            }

            else
            {
                Console.WriteLine("Bienvenido");
            }

        }
    }
}
