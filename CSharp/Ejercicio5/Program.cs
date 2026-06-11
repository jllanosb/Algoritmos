using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definir variables
            int cantidad;
            double precio=0.50, dscto, pago = 0;
            //entrada datos
            Console.WriteLine("Ingrese la cantidad de manzanas: ");
            cantidad=int.Parse(Console.ReadLine());
            //Decision
            if (cantidad > 100) {
                dscto = 0.80;
                pago = cantidad * precio * dscto;
            }
            else if (cantidad > 20) {
                dscto = 0.90;
                pago = cantidad*precio*dscto;
            }
            else {
                pago = cantidad * precio;
            }
            Console.WriteLine($"Por {cantidad} manzanas, pagaré s/. {pago}");
        }
    }
}
