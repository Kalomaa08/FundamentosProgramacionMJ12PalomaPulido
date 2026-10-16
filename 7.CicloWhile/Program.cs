using System;


namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//algoritmo qu genere los primeros 5 #s entertos + y realice y muestree sus suma
            int contador = 1;
            int acumulador = 1;
            
            while (contador < 5)
            {
                contador++;
                acumulador = acumulador + contador;
            }
            Console.WriteLine($"la suma de los 5 primeros numeros es:{acumulador}");
*/


            // algoritmo ue calcule el factorial de un numero dado por el usuario 

               int numero = 0;
            int factorial = 1; 
            int contador = 1;

            Console.WriteLine("Ingrese un número entero positivo para calcular su factorial:");
            numero = int.Parse(Console.ReadLine());
            while (contador <= numero)
            {
                factorial = factorial * contador;
                contador++; 
            }

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
    }
}





        }
