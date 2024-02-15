using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Bienvenido al calculador de impuestos!");
                Console.WriteLine("Por favor, introduce la categoría del producto:");
                Console.WriteLine("1. Medicina");
                Console.WriteLine("2. Otro");
                Console.Write("Selecciona una opción (1-2): ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalcularImpuesto(0); //para medcina
                        break;
                    case 2:
                        CalcularImpuesto(16); //16% de IVA
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("¿Deseas calcular el impuesto para otro producto? (s/n): ");
            } while (Console.ReadLine().ToLower() == "s");
        }

        static void CalcularImpuesto(double porcentajeImpuesto)
        {
            Console.Write("Introduce el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            double impuesto = (precio * porcentajeImpuesto) / 100;
            double precioTotal = precio + impuesto;

            Console.WriteLine($"Impuesto: {impuesto:C}");
            Console.WriteLine($"Precio Total: {precioTotal:C}");
        }
    }
    
}
