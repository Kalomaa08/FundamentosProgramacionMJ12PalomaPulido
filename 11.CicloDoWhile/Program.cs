using System;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            char respuesta = ' ';
            int numero = 0;
            
            do
            {
                Console.WriteLine("Ingrese un número para generar una tabla:");
                numero = int.Parse(Console.ReadLine());
                
                // Reiniciamos el contador para la tabla
                contador = 1;
                
                do
                {
                    Console.WriteLine($"-- Tabla del {numero} --");
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador++;

                } while (contador <= 10);

                Console.WriteLine("¿Desea Continuar? ('s' para sí, o cualquier otra letra para salir):");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's' || respuesta == 'S');
        }
    }
}
