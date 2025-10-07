using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class ejercicio6
    {
        public static int n1;
        public static int n2;
        public static int s;
        public static void ingreso()
        {
            Console.Write("Ingresar N1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar N2: ");
            n2 = int.Parse(Console.ReadLine());
        }
        public static void sumar()
        {
            s = n1 + n2;
        }
        public static void imprimir()
        {
            Console.WriteLine("La suma es: {0}", s);
        }

        
    }
}
        
    



