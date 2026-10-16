using System;

namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // EJERCICIO 1: 
            
            Console.WriteLine(" Ejercicio 1: Promedio de calificaciones -");
            double suma = 0;
            int contador = 0;
            char continuar = 's';

            while (continuar == 's' || continuar == 'S')
            {
                Console.WriteLine("Ingrese una calificación:");
                double calificacion = double.Parse(Console.ReadLine());
                suma += calificacion;
                contador++;

                Console.WriteLine("¿Desea ingresar otra calificación? (s/n):");
                continuar = char.Parse(Console.ReadLine());
            }

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"El promedio de las {contador} calificaciones es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }


            /*
            
            // EJERCICIO 2: COMENTADO
            
            Console.WriteLine("\n Ejercicio 2: Divisores de un número");
            Console.WriteLine("Ingrese un número entero positivo:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los divisores de {numero} son:");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */


            /*
            
            // EJERCICIO 6: COMENTADO
            
            Console.WriteLine("\n Ejercicio 6: Análisis de 40 números");
            int positivos = 0, negativos = 0, neutros = 0;
            double sumaPositivos = 0, sumaNegativos = 0;

            for (int i = 1; i <= 40; i++)
            {
                Console.WriteLine($"Ingrese el número {i} de 40:");
                double num = double.Parse(Console.ReadLine());

                if (num > 0)
                {
                    positivos++;
                    sumaPositivos += num;
                }
                else if (num < 0)
                {
                    negativos++;
                    sumaNegativos += num;
                }
                else
                {
                    neutros++;
                }
            }

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Positivos: {positivos} | Suma: {sumaPositivos}");
            Console.WriteLine($"Negativos: {negativos} | Suma: {sumaNegativos}");
            Console.WriteLine($"Neutros (ceros): {neutros}");
            */
        }
    }
}
