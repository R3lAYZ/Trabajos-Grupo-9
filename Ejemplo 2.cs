using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int n, e, r;

            Console.Write("Ingresar numero: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Ingresar exponente: ");
            e = int.Parse(Console.ReadLine());

            r = Exponente(n, e); 

            Console.Write("Resultado = {0}", r);
            Console.ReadKey();
        }

        static int Exponente(int numero, int exponente)
        {
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= numero; 
            }
            return resultado;
        }
    }
}
