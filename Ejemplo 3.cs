using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresar numero: ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
                {
                    Console.WriteLine("Error: Por favor, ingrese un número entero no negativo.");
                    Console.ReadKey();
                    return;
                }

                long f = Factorial(n); 
                Console.Write("El factorial {0}! es: {1}", n, f);
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El factorial es demasiado grande para ser calculado.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1) return 1; 

            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
