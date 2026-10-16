using System;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Arreglos unidimensionales vectores [] 
             int[] numeros = new int[5];// rango de 5
             numeros[0]= 10;
             numeros[1]= 56;
             numeros[2]= 22;
             numeros[3]= 45;
             numeros[4]= 102;
             // no se puede almacenar mas veztores que el rango 
             Console.WriteLine($"El numero almacenado en la posicion 3 con indice 2 es:{numeros[2]}");
             //otra forma de declarar e inicialixar vectores
             char[] simbolos = new char[] { '#', '&', 'ó', '0', 'a' };
             bool[] valoresVerdad = { true, false, false, true, true, false, false };

             //recorrer para almacenar datos 
             string[] nombres = new string[7];
             for (int i=0;i<7;i++)
             {
                 Console.WriteLine($"INGRESE EL NOMBRE PARA P{i + 1} : I{i}");
                 nombres[i] = Console.ReadLine();
             }
             Console.Clear();
             //Recorrer´para recuperar
             for(int i=0; i<nombres.Length; i++)
             {
                 Console.WriteLine($"{nombres[i]} |");
             }*/

         
            int inicio = 0;
            int fin = 0;

            Console.WriteLine("Ingrese el número donde inicia el rango:");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número donde termina el rango:");
            fin = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLos números múltiplos de 5 entre {inicio} y {fin} son:");

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}



        

    

