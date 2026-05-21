using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fecha y Hora
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("LLanos Bardales, Jaime");//Programador
            Console.WriteLine("Ejercicio 1 - Edad Persona");

            //Declarar Variables
            int edad;

            //Entrada de Datos
            //Mostrar mensaje al usuario para ingresar datos
            Console.WriteLine("Ingrese su edad: ");
            //Primera forma de guardar el valor ingresado por el usuario
            // Usando int.Parse
            edad = int.Parse(Console.ReadLine());

            //Decision
            /* Si -->if edad >= 18 Entonces {
             *      Mostrar "Mayor de Edad"
             *   }
             * sino else {
             *      Mostrar "Menor de Edad"
             *      }
             * finsi 
             */
            if (edad >= 18) {
                Console.WriteLine("Eres Mayor de Edad");
            }
            else {
                Console.WriteLine("Eres Menor de Edad");
            }

            //Detener pantalla
            Console.ReadKey();
        }
    }
}
