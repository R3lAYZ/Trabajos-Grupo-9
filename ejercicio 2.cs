using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ana = 34;
            int Elsa = 33;
            Console.Write("Ana cuumple años en diciembre y tiene 34 años");
            Console.Write("\nElsa cumple años mañana años");
            Console.WriteLine("\n¿Quien es mayor Ana o Elsa?:  ");
            string respuesta = Console.ReadLine();

            if (Ana > Elsa && respuesta == "Ana" || respuesta == "ana")
                Console.WriteLine("Correcto, eres un genio!");
            else if (respuesta == "Elsa" || respuesta == "elsa")
                Console.WriteLine("Incorrecto, Elsa es menor que Ana, Sigue practicando");
            else
                Console.WriteLine("Respuesta no valida");
    
    }
}
    }
