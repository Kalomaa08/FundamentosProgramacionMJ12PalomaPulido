using System;


namespace CicloWhileTaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1 ejercicio
            double sumaCalificaciones = 0;
            int cantidadCalficaciones = 0;
            string respuesta;
            do
            {
                Console.WriteLine("Ingresa una calificación:");
                double calificacion = double.Parse(Console.ReadLine());
                sumaCalificaciones += calificacion;
                cantidadCalficaciones++;
                Console.WriteLine("¿Deseas ingresas otra calificación? (Si o no):");
                respuesta = Console.ReadLine();
            } while (respuesta == "si" || respuesta == "Si");

            if (cantidadCalficaciones> 0)
            {
                double promedio = sumaCalificaciones / cantidadCalficaciones;
                Console.WriteLine($"\nEl promedio de las{cantidadCalficaciones} calificaciones ingresadas{promedio:F2}");
            }
            else
            {
                Console.WriteLine("\nNo se ingresaron calificaciones.");
            }
             Console.WriteLine("\n\nPresiona cualquier tecla para salir");*/

            /*// ejercicio 2
            Console.WriteLine(" Calculo de divisores ");
            Console.WriteLine("Ingresa un número entero:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLos divisores del número {numero} son:");

            for (int i = numero; i >= 1; i--)
            {
                if (numero % i == 0)
                {
                    Console.Write($"{i}");
                }
            }

            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");*/

            // ejercicio 3
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("Calculo de Potenciacion");

                Console.WriteLine("Ingresa la base (b):");
                int baseNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el exponente (e):");
                int exponente = int.Parse(Console.ReadLine());

                double resultado = 1;
                for (int i = 0; i < exponente; i++)
                {
                    resultado *= baseNum;
                }

                Console.WriteLine($"\nEl resultado de {baseNum}^{exponente} es: {resultado}");

                Console.WriteLine("\n¿Deseas realizar otra operación? Presiona cualquier tecla para continuar o ingresa 'n' para salir:");
                respuesta = Console.ReadLine();

            } while (respuesta?.ToLower() != "n");

            Console.WriteLine("\npresiona n para salir.");
           


        }
    }
}
