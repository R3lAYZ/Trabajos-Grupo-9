using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Program
    {
        static int exponente(int n, int expo)
        {
            int f = 1;
            if (expo == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= expo; i++)
                {
                    f = f * n;
                }
                return f;


            }
        }
    }
}
