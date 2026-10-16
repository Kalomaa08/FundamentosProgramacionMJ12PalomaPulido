using System;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // EJERCICIO 1: 
            
            Console.WriteLine(" Ejercicio 1: Tres números-");
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


            /*
            
            // EJERCICIO 2: 
           
            Console.WriteLine("\n Ejercicio 2: Disparo del personaje");
            Console.WriteLine("¿El personaje está en estado invencible? (True / False):");
            bool invencible = bool.Parse(Console.ReadLine());

            Random rnd = new Random();
            int municion = rnd.Next(1, 11);
            Console.WriteLine($"Munición generada aleatoriamente: {municion}");

            if (invencible && municion >= 1 && municion <= 10)
            {
                Console.WriteLine("El personaje está disparando");
            }
            */


            /*
            
            // EJERCICIO 4: Cñ
            
            Console.WriteLine("\n Ejercicio 4: Movimiento horizontal");
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
            */
        }
    }
}
