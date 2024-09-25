using System;

namespace Generador_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                // Variable para almacenar la opción elegida por el usuario
                int op;

                // Limpia la consola
                Console.Clear();

                // Interactua con el menu
                do
                {
                    // Muestra el menú de opciones
                    Console.WriteLine("\tMenu de Generadores");
                    Console.WriteLine("\n0 - salir.");
                    Console.WriteLine("1 - Cuadrados Medios.");
                    Console.WriteLine("2 - Metodo de los productos medios.");
                    Console.WriteLine("5 - Método Congruencial multiplicativo.");
                    Console.Write("Ingrese una opcion a ejecutar: ");

                    // Lee la opción ingresada por el usuario
                    op = int.Parse(Console.ReadLine());

                    // Muestra opciones a ejecutar
                    switch (op)
                    {
                        // Termina la ejecusion
                        case 0:
                            Console.Clear();
                            Console.WriteLine("\nGracias por ejecutar el gemerador de simulacion");
                            break;
                        // Cuadrados medios
                        case 1:
                            Console.Clear();
                            CuadradosMedios.Inicio();
                            break;
                        case 2:
                            Console.Clear();
                            Metodo_de_los_productos_medios.Inicio();
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        // Método Congruencial multiplicativo
                        case 5:
                            Console.Clear();
                            Generador_congruencial_multiplicativo.Inicio();
                            break;
                        // Mensaje por defecto 
                        default:
                            Console.Clear();
                            Console.WriteLine("Ingresa una opcion valida.\n");
                            break;
                    }

                }// Continúa mostrando el menú hasta que el usuario elija salir
                while (op != 0);
            }
			catch (Exception)
			{
                // Llama de nuevo a la función principal en caso de erro
                Main(args);

			}
        }
    }
}
