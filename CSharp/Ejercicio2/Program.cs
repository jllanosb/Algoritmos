using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leer 4 notas, hallar promedio y verificar aprobo o no
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Llanos Bardales Jaime");
            Console.WriteLine("Ejercicio 2 - Estado del Estudiante");

            //Declarar variables
            int nota1, nota2, nota3, nota4;
            float promedio;

            //Entrada de Datos
            Console.WriteLine("Ingrese nota 1: ");
            nota1=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 2: ");
            //2da forma de guardar un valor
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nota 3: ");
            //Tercer forma de guardar TryParse
            if (int.TryParse(
                Console.ReadLine(),
                out nota3)
                ) {
            }
            else {
                Console.WriteLine("El valor ingresado no es numero");
            }

            Console.WriteLine("Ingrese nota 4: ");
            nota4=int.Parse(Console.ReadLine());





        }
    }
}
