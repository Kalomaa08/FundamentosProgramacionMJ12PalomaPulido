using System;

namespace TallerProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // EJERCICIO 1: 
            
            Console.WriteLine(" Ejercicio 1: Vocales y consonantes ");
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            AnalizarPalabra(palabra);


            /*
            
            // EJERCICIO 3: 
            
            Console.WriteLine("\n Ejercicio 3: Conversor de Unidades ");
            MostrarMenuConversor();
            */


            /*
            
            // EJERCICIO 4: 
            
            Console.WriteLine("\n Ejercicio 4: Matriz de contactos ");
            GestionarContactos();
            */
        }

        static void AnalizarPalabra(string palabra)
        {
            char[] vectorChars = palabra.ToCharArray();
            int vocales = 0, consonantes = 0;

            foreach (char c in vectorChars)
            {
                char lower = char.ToLower(c);
                if ("aeiou".IndexOf(lower) >= 0) vocales++;
                else if (char.IsLetter(lower)) consonantes++;
            }

            Console.WriteLine($"Vocales: {vocales} | Consonantes: {consonantes}");
        }

        static void MostrarMenuConversor()
        {
            Console.WriteLine("1. Kilogramos a gramos\n2. Kilómetros a metros");
            int sub = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor:");
            double val = double.Parse(Console.ReadLine());

            if (sub == 1) Console.WriteLine($"{val} kg son {val * 1000} gramos");
            else if (sub == 2) Console.WriteLine($"{val} km son {val * 1000} metros");
        }

        static void GestionarContactos()
        {
            string[,] matriz = { { "Ana", "Carlos" }, { "Luis", "Sofia" } };
            Console.WriteLine("Ingrese el nombre del contacto a buscar:");
            string buscar = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j].Equals(buscar, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"¡Encontrado en [{i},{j}]! Ingrese el nuevo nombre:");
                        matriz[i, j] = Console.ReadLine();
                        encontrado = true;
                    }
                }
            }
            if (!encontrado) Console.WriteLine("Contacto no encontrado.");
        }
    }
}
