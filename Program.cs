using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B, C;
            A = "snacks"; B = "bebidas"; C = "Dulces";
            string Ele;
            Console.WriteLine("Ingrese el producto que desea comprar :");
            Console.WriteLine(A + " , " + B + " o " + C);
            Ele = Console.ReadLine();
            double Dorito = 1.30, Lays = 1.20, Piqueos = 1.50, Chess = 1.00;
            double CocaCola = 2.00, Fanta = 1.80, IncaKola = 2.20, Sprite = 1.90;
            double Snickers = 1.50, Princesa = 2.70, Sublime = 2.60, Chinchin = 1.40;
            switch (Ele)
            {
                case "snacks":
                    Console.WriteLine("Que snacks desea? (Doritos, Lays, Piqueos y Chess)");
                    string snack = Console.ReadLine();
                    if (snack == "Dorito") 
                    {
                        Console.WriteLine("El precio es de : " + Dorito);
                    }
                    else if (snack == "Lays") 
                    {
                        Console.WriteLine("El precio es de : " + Lays);
                    }
                    else if (snack == "Piqueos") 
                    {
                        Console.WriteLine("El precio es de : " + Piqueos);
                    }
                    else if (snack == "Chess") 
                    {
                        Console.WriteLine("El precio es de : " + Chess);
                    }
                    break;
                case "bebidas":
                    Console.WriteLine("Que bebidas desea?(CocaCola, Fanta, IncaKola y Sprite)");
                    string bebida = Console.ReadLine();
                    if (bebida == "CocaCola")
                    {
                        Console.WriteLine("El precio es de : " + CocaCola);
                    }
                    else if (bebida == "Fanta")
                    {
                        Console.WriteLine("El precio es de : " + Fanta);
                    }
                    else if (bebida == "IncaKola")
                    {
                        Console.WriteLine("El precio es de : " + IncaKola);
                    }
                    else if (bebida == "Sprite")
                    {
                        Console.WriteLine("El precio es de : " + Sprite);
                    }
                    break;
                    
                case "Dulces":
                    Console.WriteLine("Que dulces desea?(Snickers, Princesa, Sublime y Chinchin)");
                    string dulce = Console.ReadLine(); 
                    if (dulce == "Snickers")
                    {
                        Console.WriteLine("El precio es de : " + Snickers);
                    }
                    else if (dulce == "Princesa")
                    {
                        Console.WriteLine("El precio es de : " + Princesa);
                    }
                    else if (dulce == "Sublime")
                    {
                        Console.WriteLine("El precio es de : " + Sublime);
                    }
                    else if (dulce == "Chinchin")
                    {
                        Console.WriteLine("El precio es de : " + Chinchin);
                    }
                    break;
                 
            }
        }
    }
}
