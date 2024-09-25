using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_de_numeros
{
    public class Generador_congruencial_multiplicativo
    {
        public static void Inicio()
        {
            double x0, x1,m, a, cantNum, NumGen;

            Console.WriteLine("\tMetodo de congruencial multiplicativo\n");

            Console.Write("Cuántos números quieres que se generen: ");
            cantNum = int.Parse(Console.ReadLine());

            Console.Write("Podrías ingresar el valor de x0: ");
            x0  = int.Parse(Console.ReadLine());

            Console.Write("Podrías proporcionar el valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Podrías proporcionar el valor de m: ");
            m = int.Parse(Console.ReadLine());

            if(x0 > 0 && a > 0)
{
                for (int i = 0; i < cantNum; i++)
                {
                    x1 = (a * x0) % m;
                    NumGen = (x1/m);

                    Console.WriteLine($"\nContador = {i + 1} \nx{i} = {x0} \nNueva semilla = {x1} \nNumero Generado = {NumGen}");
                    x0 = x1;
                }
            }

            // Muestra un mensaje para que el usuario presione ENTER para salir
            Console.Write("\nPrecione ENTER para salir.");
            // Espera a que el usuario presione ENTER
            Console.ReadLine();
            // Limpia la consola
            Console.Clear();
        }

       
    }
}
