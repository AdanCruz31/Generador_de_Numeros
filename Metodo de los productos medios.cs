using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_de_numeros
{
    public  class Metodo_de_los_productos_medios
    {
        public static void Inicio()
        {
            int cantNum, x1, x2, mult;

            // Se muestra un encabezado en la consola
            Console.WriteLine("\tMetodo de los productos medios\n");

            // Se solicita al usuario la cantidad de números que desea generar
            Console.Write("Cuántos números quieres que se generen: ");
            cantNum = int.Parse(Console.ReadLine());

            Console.Write("Introduce el valor que deseas asignar a x1: ");
            x1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el valor que deseas asignar a x2: ");
            x2 = int.Parse(Console.ReadLine());

            if (Condicion(x1.ToString().Length) && Condicion(x2.ToString().Length))
            {
                for (int i = 1; i < cantNum + 1; i++)
                {
                    mult = x1 * x2;

                   
                }


            }


        }

        static bool Condicion(int num)
        {
            // Inicializa la variable 'con' como false
            bool con = false;

            // Verifica si el número es par
            if (num % 2 == 0)
            {
                // Si es par, cambia 'con' a true
                con = true;
            }

            // Devuelve el resultado
            return con;
        }
    }
}
