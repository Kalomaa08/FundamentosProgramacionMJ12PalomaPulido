using System;


namespace Taller_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[,] matriz = new int[10, 20];
           Random aleatorio = new Random();

               
           for (int f = 0; f < 10; f++)
           {
             for (int c = 0; c < 20; c++)
             {
               matriz[f, c] = aleatorio.Next(1, 10); 
             }
           }
          Console.WriteLine("matriz (10 filas x 20 columnas) ");
           for (int f = 0; f < 10; f++)
           {
              for (int c = 0; c < 20; c++)
              {
                 Console.Write(matriz[f, c] + "\t"); 
              }
              Console.WriteLine(); 
           }

           for (int c = 0; c < 20; c++)
           {
              int sumaColumna = 0;
                    
              for (int f = 0; f < 10; f++)
              {
                sumaColumna = sumaColumna + matriz[f, c];
              }

                    
              Console.WriteLine("Suma de la columna " + (c + 1) + ": " + sumaColumna);
                
           }
        }
    
    }
}
