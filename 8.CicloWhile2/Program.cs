using System;


namespace _8.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacer un algoritme que pida numeros enteros positivos t los sume, hasta que se ingrese un numero entero negativo, se debe mostrar en pantalla el total de la suma de los nmeros guardados 

            int sumaEnteros = 0;
            int numero = 0;
            Console.WriteLine("ingrese un numeo para sumar");
            numero = int.Parse(Console.ReadLine());
            while(numero>=0)
            {
                sumaEnteros += numero;
                Console.WriteLine("ingrese un numeo para sumar");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma de los numeros es : {sumaEnteros}");
        }
    }
}
