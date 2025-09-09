using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUM1;
            string linea;
            long RESUL;
            Console.Write("Digite un número :");
            NUM1 = int.Parse(Console.ReadLine());
            RESUL = Math.Abs(NUM1);
            Console.WriteLine();
            Console.WriteLine("Valor absoluto : " + RESUL);
            Console.WriteLine("Potencia : " + Math.Pow(NUM1, 5));
            Console.WriteLine("Raíz cuadrada : " + Math.Sqrt(NUM1));
            Console.WriteLine("Núm. máximo : " + Math.Max(NUM1, 55));
            Console.WriteLine("Núm. mínimo : " + Math.Min(NUM1, 55));
            Console.WriteLine("Parte entera : " + Math.Floor(19.88));
            Console.WriteLine("Redondeo : " + Math.Round(19.88));
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
