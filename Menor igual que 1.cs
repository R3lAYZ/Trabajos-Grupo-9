using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad1 = 10;
            int edad2 = 12;
            Console.Write("Pedro tiene 10 años");
            Console.Write("\nPablo tiene 12 años");
            Console.Write("\n¿Quien es menor?: ");
            string respuesta = Console.ReadLine();

            if (edad1 < edad2 && respuesta == "Pedro")
                Console.WriteLine("Correcto Pedro es menor que Pablo");
            else if (respuesta == "pedro")
                Console.WriteLine("Correcto Pedro es menor que Pablo");
            else if (respuesta == "Pablo")
                Console.WriteLine("Incorrecto Pablo es mayor que Pedro");
            else if (respuesta == "pablo")
                Console.WriteLine("Incorrecto pablo es mayor que Pedro");
            else
                Console.WriteLine("No haz respondido correctamente");

        
               
            

            

       

          



        }
    }
}
