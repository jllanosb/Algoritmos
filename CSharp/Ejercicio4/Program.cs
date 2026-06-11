using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir Variables
            int num;
            //Pedir al usuario ingresar datos
            Console.WriteLine("Ingrese un numero: ");
            num=int.Parse(Console.ReadLine());

            if (num > 0) {
                Console.WriteLine("El numero es mayor que cero");
            }
            else if (num==0) {
                Console.WriteLine("El numero es cero");
            }
            else {
                Console.WriteLine("El numero es menor que cero");
            }

            Console.ReadKey(); //Pausar y mostrar el resultado
        }
    }
}
