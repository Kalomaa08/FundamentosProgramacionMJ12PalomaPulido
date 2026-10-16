using System;

namespace _17.ArreglosBidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz de 10 filas y 20 columnas
            int[,] numeros = new int[10, 20];

            // 1. Ciclo para asignar el número 100 en cada posición automáticamente
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    numeros[i, j] = 100;
                }
            }

            // 2. Ciclo para recorrer la matriz y mostrarla en consola
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    Console.Write($"{numeros[i, j]} ");
                }
                Console.WriteLine(); // Salto de línea al terminar cada fila
            }
        }
    }
}
