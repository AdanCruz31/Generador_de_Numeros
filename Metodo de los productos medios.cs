using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_de_numeros
{
    public  class Metodo_de_los_productos_medios
    {
        public static void Inicio()
        {
            // Declaración de variables
            int cantNum, x1, x2, mult, cantCeros, longitudX, inicio, fin;
            string cerosMult = "", cuadradoStr, caracteresMedio;
            double numeroDecimal = 0.0;

            // Mensaje inicial del método
            Console.WriteLine("\tMetodo de los productos medios\n");

            // Solicitar la cantidad de números a generar
            Console.Write("Cuántos números quieres que se generen: ");
            cantNum = int.Parse(Console.ReadLine());

            // Solicitar el valor inicial para x1
            Console.Write("Introduce el valor que deseas asignar a x1: ");
            x1 = int.Parse(Console.ReadLine());

            // Solicitar el valor inicial para x2
            Console.Write("Introduce el valor que deseas asignar a x2: ");
            x2 = int.Parse(Console.ReadLine());

            // Verificar que las longitudes de x1 y x2 sean válidas
            if (Condicion(x1.ToString().Length) && Condicion(x2.ToString().Length) && x1.ToString().Length == x2.ToString().Length)
            {
                // Ciclo para generar los números
                for (int i = 0; i < cantNum ; i++)
                {
                    // Calcular el producto de x1 y x2
                    mult = x1 * x2;
                    cerosMult = "";

                    // Comprobar la longitud del producto para determinar si necesita ceros a la izquierda
                    if (mult.ToString().Length != 2 * (x1.ToString().Length))
                    {         
                        cantCeros = 2 * (x1.ToString().Length);
                        // Formatear el número con ceros a la izquierda
                        cerosMult = mult.ToString($"D{cantCeros}");
                    }
                    else
                    {
                        cerosMult = mult.ToString();
                    }

                    // Convertir el producto a string 
                    cuadradoStr = mult.ToString();
                    // Obtener la longitud de x1
                    longitudX = x1.ToString().Length;
                    // Calcular el índice de inicio y fin para obtener los caracteres del medio
                    inicio = (cuadradoStr.Length - longitudX) / 2;                    
                    fin = inicio + longitudX;
                    // Extraer los caracteres del medio del producto
                    caracteresMedio = cuadradoStr.Substring(inicio, longitudX);

                    // Convertir los caracteres del medio a un número decimal
                    if (int.Parse(caracteresMedio) < 100.0)
                    {
                        numeroDecimal = int.Parse(caracteresMedio) / 100.0;
                    }
                    else
                    {
                        numeroDecimal = int.Parse(caracteresMedio) / 10000.00;
                    }

                    // Imprimir los resultados en consola
                    Console.WriteLine($"\nContador: {i + 1} \nx{i}: {x1} \nx{i + 1}: {x2} \nMultiplicasion: {cerosMult} \nx{i + 2}: {caracteresMedio} \nNumero Generado: {numeroDecimal}");

                    // Actualizar x1 y x2 para la siguiente iteración
                    x1 = x2;
                    x2 = int.Parse(caracteresMedio);

                    
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
                // Mensaje si no se cumple la condición
                Console.WriteLine("\nLos valores de x1 y x2 deben tener la misma longitud y cumplir con las condiciones establecidas.");
                // Muestra un mensaje para que el usuario presione ENTER para salir
                Console.Write("\nPrecione ENTER para salir.");
                // Espera a que el usuario presione ENTER
                Console.ReadLine();
                // Limpia la consola
                Console.Clear();
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
