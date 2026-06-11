using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Random genera = new Random(); //Metodo para aleatorios

            n1= genera.Next(5,9);
            Console.WriteLine($"Numero 1: {n1}");
            n2= genera.Next(5,9);
            Console.WriteLine($"Numero 2: {n2}");
            n3 = genera.Next(5,9);
            Console.WriteLine($"Numero 3: {n3}");

            if (n1 == n2 && n2 == n3) {
                Console.WriteLine("Premio s/100");
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3) {
                Console.WriteLine("Premio s/50");
            }
            else {
                Console.WriteLine("No hay Premio");
            }
        }
    }
}
