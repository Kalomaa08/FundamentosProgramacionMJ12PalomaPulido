using System;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" TALLER DE CONDICIONALES ");
            Console.WriteLine("Seleccione el ejercicio a ejecutar (1, 2 o 4):");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Ejercicio 1: Leer tres números, verificar si son diferentes, mostrar el mayor y ordenarlos de menor a mayor
                Console.WriteLine("\n--- Ejercicio 1: Tres números ---");
                Console.WriteLine("Ingrese el número 1:");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número 2:");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número 3:");
                int n3 = int.Parse(Console.ReadLine());

                if (n1 == n2 || n1 == n3 || n2 == n3)
                {
                    Console.WriteLine("Error: Se deben ingresar números diferentes.");
                }
                else
                {
                    int mayor = n1;
                    if (n2 > mayor) mayor = n2;
                    if (n3 > mayor) mayor = n3;
                    Console.WriteLine($"El número mayor es: {mayor}");

                    
                    if (n1 > n2) { int temp = n1; n1 = n2; n2 = temp; }
                    if (n1 > n3) { int temp = n1; n1 = n3; n3 = temp; }
                    if (n2 > n3) { int temp = n2; n2 = n3; n3 = temp; }
                    Console.WriteLine($"Números ordenados de menor a mayor: {n1}, {n2}, {n3}");
                }
            }
            else if (opcion == 2)
            {
                // Ejercicio 2: Disparar si es invencible y la munición aleatoria (1-10) es válida
                Console.WriteLine("\n--- Ejercicio 2: Disparo del personaje ---");
                Console.WriteLine("¿El personaje está en estado invencible? (True / False):");
                bool invencible = bool.Parse(Console.ReadLine());

                Random rnd = new Random();
                int municion = rnd.Next(1, 11); // Genera entre 1 y 10
                Console.WriteLine($"Munición generada aleatoriamente: {municion}");

                if (invencible && municion >= 1 && municion <= 10)
                {
                    Console.WriteLine("El personaje está disparando");
                }
            }
            else if (opcion == 4)
            {
                // Ejercicio 4: Movimiento horizontal según la tecla presionada
                Console.WriteLine("\n--- Ejercicio 4: Movimiento horizontal ---");
                Console.WriteLine("Presione una tecla ('d' para derecha, 'i' para izquierda):");
                char tecla = char.Parse(Console.ReadLine());

                if (tecla == 'd' || tecla == 'D')
                {
                    Console.WriteLine("El personaje se mueve hacia la derecha");
                }
                else if (tecla == 'i' || tecla == 'I')
                {
                    Console.WriteLine("El personaje se mueve hacia la izquierda");
                }
                else
                {
                    Console.WriteLine("No me puedo mover en otra dirección");
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
