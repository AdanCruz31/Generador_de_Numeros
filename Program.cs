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

                //LIMPIA LA CONSOLA
                Console.Clear();

                //UN DO WHILE PARA INTERACTUAR CON EL MENU
                do
                {
                    Console.WriteLine("\tMenu de Generadores");
                    Console.WriteLine("\n0 - salir.");
                    Console.WriteLine("1 - Cuadrados Medios.");
                    Console.Write("Ingrese una opcion a ejecutar: ");
                    op = int.Parse(Console.ReadLine());

                    //NUESTRAS OPCIONES A EJECUTAR
                    switch (op)
                    {
                        //TERMINA LA EJECUCION
                        case 0:
                            Console.Clear();
                            Console.WriteLine("\nGracias por ejecutar el gemerador de simulacion");
                            break;
                        //CUADRADOS MEDIOS
                        case 1:
                            Console.Clear();
                            CuadradosMedios.Inicio();
                            break;
                        //MENSAJE POR DEFECTO 
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
                //ATRAPA NUESTRA EXPECION EVITANDO QUE TRUENE Y PODER EJECUTAR EL CODIGO
                Main(args);

			}
        }
    }
}
