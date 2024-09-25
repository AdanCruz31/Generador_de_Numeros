using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_de_numeros
{
    public class CuadradosMedios
    {

        public static void Inicio()
        {
            // Se declaran las variables necesarias
            int cantNum, semilla, cuadradoX, canCeros, longitudX, inicio, fin;
            string CerosX = "", cuadradoStr, caracteresMedio;
            double numeroDecimal = 0.0;

            // Se muestra un encabezado en la consola
            Console.WriteLine("\tCuadrados Medios\n");

            // Se solicita al usuario la cantidad de números que desea generar
            Console.Write("Cuántos números quieres que se generen: ");
            cantNum = int.Parse(Console.ReadLine());

            // Se solicita al usuario que ingrese el valor de la semilla
            Console.Write("Por favor, ingresa el valor de la semilla que deseas utilizar: ");
            semilla = int.Parse(Console.ReadLine());

            // Se verifica si la longitud de la semilla es válida
            if (Condicion(semilla.ToString().Length))
            {
                // Si la condición es válida, se inicia un ciclo para generar los números
                for (int i = 1; i < cantNum + 1; i++)
                {
                    // Calcula el cuadrado de la semilla
                    cuadradoX = semilla * semilla;
                    //Limpia la variable
                    CerosX = "";
                    // Verifica si la longitud del cuadrado no es válida según la función Condicion
                    if (cuadradoX.ToString().Length != 2 * (semilla.ToString().Length))
                    {
                        // Si la longitud no es válida, se calcula cuántos ceros se necesitan
                        canCeros = 2 * semilla.ToString().Length;
                        // Se convierte el cuadrado a una cadena con ceros a la izquierda, según canCeros
                        CerosX = cuadradoX.ToString($"D{canCeros}");
                    }
                    else
                    {
                        CerosX = cuadradoX.ToString();
                    }

                    // Convierte el cuadrado a una cadena
                    cuadradoStr = cuadradoX.ToString();
                    // Obtiene la longitud de la representación en cadena de la semilla
                    longitudX = semilla.ToString().Length;
                    // Calcula la posición de inicio para extraer los caracteres del cuadrado
                    inicio = (cuadradoStr.Length - longitudX) / 2;
                    // Calcula la posición final para la extracción de caracteres
                    fin = inicio + longitudX;
                    // Extrae la subcadena centrada del cuadrado
                    caracteresMedio = cuadradoStr.Substring(inicio, longitudX);
                    // Convierte 'caracteresMedio' a entero y luego a decimal, dividiendo por 100.0
                    if (int.Parse(caracteresMedio) < 100.0)
                    {
                        numeroDecimal = int.Parse(caracteresMedio) / 100.0;
                    }
                    else
                    {
                        numeroDecimal = int.Parse(caracteresMedio) / 10000.00;
                    }
                    // Imprime la información de Cuadrados Medios
                    Console.WriteLine($"\nContador: {i} \nSemilla: {semilla} \nCuadrado de la semilla: {CerosX} \nNueva Semilla: {caracteresMedio} \nNumero Generado: {numeroDecimal}\n");
                    // Actualiza la semilla con el nuevo valor
                    semilla = int.Parse(caracteresMedio);
                }

                // Muestra un mensaje para que el usuario presione ENTER para salir
                Console.Write("\nPrecione ENTER para salir.");
                // Espera a que el usuario presione ENTER
                Console.ReadLine();
                // Limpia la consola
                Console.Clear();
            }
            else
            {
                // Limpia la consola para un visual limpio
                Console.Clear();
                // Muestra un mensaje de error indicando que la longitud de la semilla debe ser un entero
                Console.WriteLine("La cantidad de cifras debe de ser entero para la semilla");
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
