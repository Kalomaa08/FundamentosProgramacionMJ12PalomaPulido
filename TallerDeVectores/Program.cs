using System;

namespace TallerDeVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*               const int lol= 16; // ejercicio 1
                            int[] vector = new int[lol];

                            Console.WriteLine("ingrese 15 números");

                            for (int i = 1; i < lol; i++)
                            {
                                Console.Write($"Ingrese el número para la posición [{i}]: ");
                            while (!int.TryParse(Console.ReadLine(), out vector[i]))
                            {
                                Console.Write($"  [Error] Entrada inválida. Ingrese un número entero para [{i}]: ");
                            }

                            }

                            int maximo = vector[0];
                            int minimo = vector[0];

                            for (int i = 1; i < lol; i++)
                            {
                                if (vector[i] > maximo)
                                {
                                    maximo = vector[i];
                                }
                                if (vector[i] < minimo)
                                {
                                    minimo = vector[i];
                                }
                            }

                            Console.WriteLine($"Valor máximo: {maximo}");
                            Console.WriteLine($"Valor mínimo: {minimo}");*/

            //ejercicio 2
            
                
                int[] v1 = new int[5];
                int[] v2 = new int[5];

                v1[0] = 10; v2[0] = 10;  
                v1[1] = 20; v2[1] = 99;  
                v1[2] = 30; v2[2] = 30;  
                v1[3] = 40; v2[3] = 40;  
                v1[4] = 50; v2[4] = 5;   

                
                int totalIguales = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (v1[i] == v2[i])
                    {
                        totalIguales++; 
                    }
                }

                
                Console.WriteLine("Cuántos son iguales en la misma posición: " + totalIguales);

                Console.ReadKey();
           
        }
    }
}
