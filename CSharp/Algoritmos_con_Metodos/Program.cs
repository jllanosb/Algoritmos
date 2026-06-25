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
                //Condicional Multiple
                switch (opcion) {
                    case 0: Console.WriteLine("Saliendo del sistema..."); break;
                    case 1: DescuentoTienda(); break;
                    case 2: ClasificarEstudiantes(); break;
                    case 3: TipoViaje(); break;
                    case 4: ClasificarProductos(); break;
                    case 5: CategoriaVehiculos(); break;
                    case 6: DecisionTransporte(); break;
                    default: Console.WriteLine("Opcion Incorrecta"); break;
                }
                Console.ReadKey();//Pausar para mostrar resultados
                Console.Clear(); //Limpiar la pantalla
            } while (opcion != 0);
        }
        //Metodo para el caso 1
        static void DescuentoTienda() {
            double descuento;
            Console.WriteLine("Descuento en Tienda");
            Console.WriteLine("Ingrese el monto de compra");
            var monto = int.Parse(Console.ReadLine());
            //condicional anidado
            if (monto > 1000) { 
                descuento = monto*0.20;
            }
            else if (monto > 500) {
                descuento = monto * 0.10;
            }
            else {
                descuento = 0;
            }
            Console.WriteLine($"El descuento obtenido es s/. {descuento} ");
            Console.WriteLine($"Monto a pagar es s/. {monto - descuento}");
        }
        //Metodo para el Caso 2
        static void ClasificarEstudiantes() {
            //Usar metodo para generar numeros aleatorios RANDOM
            double calificacion;
            Random genera = new Random();
            Console.WriteLine("Clasificacion de Estudiantes");
            calificacion = genera.Next(0,120); //obteniendo el numero aleatorio 0 y 120
            Console.WriteLine($"Calificacion obtenida: {calificacion} puntos");
            //Condicional anidado
            if (calificacion >= 90) {
                Console.WriteLine("Clasifica estudiante como Excelente");
            }
            else if (calificacion >= 80 && calificacion < 90) {
                Console.WriteLine("Clasifica estudiante como Muy bueno");
            }
            else if (calificacion >= 70 && calificacion < 80) {
                Console.WriteLine("Clasifica estudiante como Bueno");
            }
            else if (calificacion >= 60 && calificacion < 70) {
                Console.WriteLine("Clasifica estudiante como Suficiente");
            }
            else {
                Console.WriteLine("Clasifica estudiante como Insuficiente");
            }
        }
        //Metodo para el caso 3
        static void TipoViaje() {
            int dias;
            double presupuesto;
            Console.WriteLine("Tipo de Viaje");
            Console.WriteLine("Ingrese los dias de viaje");
            dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el presupuesto disponible (s/.)");
            presupuesto = double.Parse(Console.ReadLine());
            //condicional anidado
            if (dias < 3 && presupuesto < 500) {
                Console.WriteLine("Tipo de Viaje: Escapadita de Fin de Semana");
            }
            else if (dias > 15 && presupuesto > 5000) {
                Console.WriteLine("Tipo de Viaje: Internacional de Lujo");
            }
            else if ((dias > 7 && dias < 15) && (presupuesto > 2000 && presupuesto < 5000)) {
                Console.WriteLine("Tipo de Viaje: Internacional");
            } else if ((dias < 7 && presupuesto < 2000){
                Console.WriteLine("Tipo de Viaje: Nacional");
            }
            else {
                Console.WriteLine("Tipo de Viaje No Clasificado !!!");
            }
        }
        static void ClasificarProductos()
        {

        }
        static void CategoriaVehiculos() { 

        }
        static void DecisionTransporte() { 
            
        }
    }
}
