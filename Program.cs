using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerrcicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                int a = 10, b = 10;
                ejercicio7.incremento1(a);
                Console.WriteLine("a = {0}", a);
                ejercicio7.incremento2(ref b);
                Console.WriteLine("b = {0}", b);
                Console.ReadKey();
            

        }
    }
}
