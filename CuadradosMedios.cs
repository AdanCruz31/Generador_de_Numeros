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
            int cant = 0, semilla = 0;

            Console.Write("Cuantos numeros deceas generar: ");
            cant = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el valor de la semilla: ");
            semilla = int.Parse(Console.ReadLine());

            if (Condicion(semilla))
            {
                
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
