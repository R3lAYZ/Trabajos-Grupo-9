using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, contador = 0, nota;
            double promedio;
            Console.WriteLine("ingrese la nota");
            nota = int.Parse(Console.ReadLine());
            while (nota != -1)
            {
                suma = nota + suma;
                contador++;
                Console.WriteLine("Ingrese su siguiente nota");
                Console.WriteLine("Si ya no quiere ingresar mas notas coloque (-1)");
                nota =int.Parse(Console.ReadLine());
            }
            if (contador > 0)
            {
                promedio = suma / contador;
                Console.WriteLine("El promedio de las notas es: " + (suma / contador));
                Console.WriteLine("La suma de las notas es: " + suma);
                Console.WriteLine("La cantidad de notas ingresadas es: " + contador);
                Console.WriteLine("El promedio de las notas es: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron notas");
            }

        }
    }
}
