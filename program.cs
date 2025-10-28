using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general_borra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* // Con estructura repetitiva (For)
             Console.WriteLine("Ingrese el valor de N");
             int sumatotal = 0;
             int N = int.Parse(Console.ReadLine());
             int[] valores = new int[N];
             Random rand = new Random();
             for (int i = 0; i < N; i++)
             {
                 valores[i] = rand.Next(1, 100);
                 sumatotal += valores[i];
             }
             Console.WriteLine("El total de la suma es: " +sumatotal);

             // con estructura repetitiva (while)
             int a = 0;
             int total = 0;
             while (a < N)
             {

                 valores[a] = rand.Next(1, 100);
                 total += valores[a];
                 a++;
             }
             Console.WriteLine("El total de la suma es: "+total);
             // con estructura repetitiva (do-while)
             int b = 0;
             int todo=0;
             do
             {

                valores[b]= rand.Next(1, 100);
                 todo += valores[b];
                 b++;
             }
             while (b < N);
            Console.WriteLine("El total de la suma es: " + todo);*/


            int peliculas = 0;
            Console.WriteLine("Ingrese la cantidad de datos que va a guardar");
            peliculas= int.Parse(Console.ReadLine());
            string[] tpeliculas = new string[peliculas];
            for (int i = 0; i < peliculas; i++)
            {
                Console.WriteLine("ingrese el nombre de las pelicula: ");
                tpeliculas[i] = Console.ReadLine();
            }    
            
            int b = 0;
            while (b < tpeliculas.Length)
            {
                Console.WriteLine("pelicula: " +tpeliculas[b]);
                    b++;
            }
            
            








        }
    }
}
