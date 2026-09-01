using System;


namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        /*{
            //Ciclo Do While 
            int contador = 1;
            int acumulador = 0;

            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine($"la suma de los primeros numeros enteros es: {acumulador} ");


        }*/
        {
            int contador = 0;
            char respuesta = ' ';
            int numero = 0;
            do
            {
                Console.WriteLine("ingrese un numero paea generar una tabla");
                numero = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"--Tabla del {numero} --");
                    Console.WriteLine($"{numero}X{contador}={numero * contador}");
                    contador++;

                } while (contador <= 10);
                contador = 1;
                Console.WriteLine("Desea Continuar? : Si o cualquier caracter para salir");
                respuesta = char.Parse(Console.ReadLine());

            }while (respuesta==)


        }
    }
}
