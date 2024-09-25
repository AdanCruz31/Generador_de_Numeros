using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_de_numeros
{
    public class CuadradosMedios
    {

        public static void Inicio()
        {
            Console.WriteLine("\tCuadrados medios\n");
            int cant, semilla, izq, semilla2, canCeros;
            string semillaConCeros = "" ;

            Console.Write("Cuántos números deseas generar: ");
            cant = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el valor de la semilla: ");
            semilla = int.Parse(Console.ReadLine());

            if (Condicion(semilla.ToString().Length))
            {
                for (int i = 0; i < cant; i++)
                {
                    semilla2 = semilla * semilla;

                    if (!Condicion(semilla2.ToString().Length))
                    {
                        canCeros = 2 * semilla.ToString().Length;
                        semillaConCeros = semilla2.ToString($"D{canCeros}");
                    }

                }
            }
            else
            {
                Console.WriteLine("La semilla no cumple con la condición.");
            }
        }

        static bool Condicion(int num)
        {
            bool con = false;

            if (num % 2 == 0)
            {
                con = true;
            }

            return con;
        }
    }
}
