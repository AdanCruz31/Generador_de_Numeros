using System;

namespace Generador_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int op;

                Console.Clear();

                do
                {
                    Console.WriteLine("Menu de Generadores");
                    Console.WriteLine("\n0 - salir.");
                    Console.WriteLine("1 - Cuadrados Medios.");
                    Console.Write("Ingrese una opcion a ejecutar: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("\nGracias por ejecutar el gemerador de simulacion");
                            break;
                        case 1:
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Ingresa una opcion valida.\n");
                            break;
                    }
                }
                while (op != 0);
            }
			catch (Exception)
			{
                Main(args);

			}
        }
    }
}
