using System;

namespace Generador_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
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
                    default:
                        break;
                }
            }
            while (op != 0);
        }
    }
}
