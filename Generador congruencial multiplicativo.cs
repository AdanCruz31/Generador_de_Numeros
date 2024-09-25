using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_de_numeros
{
    public class Generador_congruencial_multiplicativo
    {
        public static void Inicio()
        {
            // Declaración de variables
            double x0, x1,m, a, cantNum, NumGen;

            // Mensaje de inicio del programa
            Console.WriteLine("\tMetodo de congruencial multiplicativo\n");

            // Solicitar al usuario cuántos números quiere generar
            Console.Write("Cuántos números quieres que se generen: ");
            cantNum = int.Parse(Console.ReadLine());

            // Solicitar al usuario el valor inicial x0
            Console.Write("Podrías ingresar el valor de x0: ");
            x0  = int.Parse(Console.ReadLine());

            // Solicitar al usuario el valor de a
            Console.Write("Podrías proporcionar el valor de a: ");
            a = int.Parse(Console.ReadLine());

            // Solicitar al usuario el valor de m
            Console.Write("Podrías proporcionar el valor de m: ");
            m = int.Parse(Console.ReadLine());

            // Verificar que x0 y a sean enteros antes de proceder
            if (x0 > 0 && a > 0)
{
                // Generar la cantidad de números solicitada
                for (int i = 0; i < cantNum; i++)
                {

                    // Calcular el nuevo valor de x1 usando el método congruencial multiplicativo
                    x1 = (a * x0) % m;
                    // Calcular el número generado dividiendo x1 entre m
                    NumGen = (x1/m);

                    // Mostrar los resultados en consola
                    Console.WriteLine($"\nContador = {i + 1} \nx{i} = {x0} \nNueva semilla = {x1} \nNumero Generado = {NumGen}");

                    // Actualizar x0 para la próxima iteración
                    x0 = x1;
                }
            }
            else
            {
                Console.WriteLine("\nLos valores de x0 y a deben ser mayores que 0. Por favor, ingresa valores válidos.");
                // Muestra un mensaje para que el usuario presione ENTER para salir
                Console.Write("\nPrecione ENTER para salir.");
                // Espera a que el usuario presione ENTER
                Console.ReadLine();
                // Limpia la consola
                Console.Clear();
            
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
