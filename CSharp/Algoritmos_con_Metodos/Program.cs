using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_con_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodo Menu
            MenuOpciones();
        }
        //Metodo Menu
        static void MenuOpciones() {
            int opcion;
            //Estructura repetitiva Do While 
            do {
                Console.WriteLine(" ### Menu Casos Algoritmos ### ");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("1. Descuento Tienda");
                Console.WriteLine("2. Clasificacion Estudiantes");
                Console.WriteLine("3. Tipo de Viaje");
                Console.WriteLine("4. Clasificacion Productos");
                Console.WriteLine("5. Categoria Vehiculos");
                Console.WriteLine("6. Decision Transporte");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear(); //Limpiar la pantalla
            } while (opcion != 0);
        }
    }
}
