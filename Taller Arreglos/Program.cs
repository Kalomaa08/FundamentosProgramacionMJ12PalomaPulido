using System;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // EJERCICIO 1: 
            
            Console.WriteLine(" Ejercicio 1: Suma por columnas en Matriz 10x20 ");
            int[,] matriz = new int[10, 20];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine("\nSuma de cada columna:");
            for (int j = 0; j < 20; j++)
            {
                int sumaColumna = 0;
                for (int i = 0; i < 10; i++)
                {
                    sumaColumna += matriz[i, j];
                }
                Console.WriteLine($"Columna {j}: {sumaColumna}");
            }


            /*
            
            // EJERCICIO 2: 
            
            Console.WriteLine("\n  Ejercicio 2: Intercambiar primera y última fila ");
            Console.WriteLine("Ingrese filas (n):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese columnas (m):");
            int m = int.Parse(Console.ReadLine());

            char[,] matriz2 = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese carácter para [{i},{j}]:");
                    matriz2[i, j] = char.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < m; j++)
            {
                char temp = matriz2[0, j];
                matriz2[0, j] = matriz2[n - 1, j];
                matriz2[n - 1, j] = temp;
            }

            Console.WriteLine("\nMatriz con filas intercambiadas con éxito.");
            */


            /*
            
            // EJERCICIO 5: 
            
            Console.WriteLine("\n Ejercicio 5: Convertir filas en columnas (Transpuesta) ");
            Console.WriteLine("Ingrese filas:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese columnas:");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz5 = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese entero para [{i},{j}]:");
                    matriz5[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] transpuesta = new int[columnas, filas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    transpuesta[j, i] = matriz5[i, j];
                }
            }

            Console.WriteLine("\nMatriz convertida (filas a columnas) generada correctamente.");
            */
        }
    }
}
