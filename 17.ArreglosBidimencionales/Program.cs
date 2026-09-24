using System;


namespace _17.ArreglosBidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Arreglos Bidimensionales - Matrices 
            int[,] numeros = new int[2, 3]; // declarando , y la matriz va a ser de 2 filas 3 columnas
            numeros[0,0] = 25;
            numeros[0,1] = 41;
            numeros[0,2] = 104;
            numeros[1,0] = 47;
            numeros[1,1] = 56;
            numeros[1,2] = 6;

            Console.WriteLine($"El valor almacenado en numeros [1,1] es {numeros[1, 1]}");
            char[,] simbolos = new char[2, 3];

            // recorrer para llenar 
            for(int i=0;i<3;i++)// recorre las filas 
            {
                for(int j=0;j<2;j++ )// recorre las columnas 
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos[{i},{j}]");
                    simbolos[i, j] = char.Parse(Console.ReadLine()); 
                }
            }


            //Recorrer para recuperar
            for (int i = 0; i < simbolos.GetLength(0); i++) // devuelve el numero de filas 
            {
                for (int j = 0; j < simbolos.GetLength(1); j++) // devuelve el nmero de columnas 
                {
                    Console.Write($" {simbolos[i, j]} |");
                }
                Console.WriteLine();
            }

            // declarar e inicializar matrices
            string[,] nombres ={
                                 {"Ana","Carlos","Alex","Mauricio" },
                                 {"Juan","Marta", "María","Alvaro" },
                                 {"Ramiro", "Guillermo", "Cristian", "Blanca"}
                               };*/



            //Matriz[10,20] en cada posicion de la matriz el numero 100, y que aparesca en consola 
            int[,] numeros = new int[10, 20];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos[{i},{j}]");
                    numeros[i, j] = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine($" {numeros[i,j]} |");
                Console.WriteLine();
            }






        }
    }
}
