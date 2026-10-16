using System;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // EJERCICIO 1: 
            
            Console.WriteLine("Ejercicio 1: Máximo y Mínimo en Vector[15]");
            int[] vec = new int[15];

            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine($"Ingrese el número para la posición {i}:");
                vec[i] = int.Parse(Console.ReadLine());
            }

            int max = vec[0];
            int min = vec[0];

            for (int i = 1; i < vec.Length; i++)
            {
                if (vec[i] > max) max = vec[i];
                if (vec[i] < min) min = vec[i];
            }

            Console.WriteLine($"El valor máximo es: {max}");
            Console.WriteLine($"El valor mínimo es: {min}");


            /*
            
            // EJERCICIO 3: 
            
            Console.WriteLine("\n Ejercicio 3: Promedio y comparación en Vector[20] ");
            int[] vec3 = new int[20];
            Random rnd = new Random();
            int suma = 0;

            for (int i = 0; i < vec3.Length; i++)
            {
                vec3[i] = rnd.Next(1, 100);
                suma += vec3[i];
            }

            double promedio = (double)suma / vec3.Length;
            Console.WriteLine($"Promedio aritmético: {promedio}");

            int mayores = 0, menores = 0;
            for (int i = 0; i < vec3.Length; i++)
            {
                if (vec3[i] > promedio) mayores++;
                else if (vec3[i] < promedio) menores++;
            }

            Console.WriteLine($"Mayores que el promedio: {mayores}");
            Console.WriteLine($"Menores que el promedio: {menores}");
            Console.WriteLine("Vector completo: " + string.Join(", ", vec3));
            */


            /*
            
            // EJERCICIO 4: 
            
            Console.WriteLine("\n Ejercicio 4: Vector de caracteres invertido ");
            Console.WriteLine("Ingrese el tamaño del vector:");
            int tam = int.Parse(Console.ReadLine());

            char[] original = new char[tam];
            char[] invertido = new char[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine($"Ingrese el carácter para la posición {i}:");
                original[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tam; i++)
            {
                invertido[i] = original[tam - 1 - i];
            }

            Console.WriteLine("Vector Original: " + string.Join(" ", original));
            Console.WriteLine("Vector Invertido: " + string.Join(" ", invertido));
            */
        }
    }
}
