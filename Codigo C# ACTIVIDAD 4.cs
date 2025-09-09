using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioP1, cantiU;
            Console.WriteLine("Ingrese el precio del producto");
            precioP1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cuanto va a comprar");
            cantiU = double.Parse(Console.ReadLine());
            double subtotal = precioP1 * cantiU;
            double descuento;
            if (subtotal >= 100)
            {
                Console.WriteLine("Aplica a descuento del 15%");
                descuento = subtotal * 0.15;
            }
            else 
            {
                Console.WriteLine("No aplica a descuento");
                descuento = 0;
            }
            double total = subtotal - descuento;
            Console.WriteLine("Usted pagara " + total);
            Console.ReadKey();  
        }
    }
}
