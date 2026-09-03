using System;

namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int numero;
            float saldo;
            int contador = 0;
            float acumulado = 0;
            string respuesta;
            float promedio;
            do
            {
                contador++;
                Console.WriteLine("Cual es su nombre?");
                nombre = Console.ReadLine();
                Console.WriteLine("Cual es el número de su cuenta");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Cual es su saldo");
                saldo = float.Parse(Console.ReadLine());
                acumulado += saldo;
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numero}");
                    Console.WriteLine($"Cantidad de saldo: {saldo}");
                    Console.WriteLine("Usted es apto para el credito");
                }
                else
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numero}");
                    Console.WriteLine($"Cantidad de saldo: {saldo}");
                    Console.WriteLine("Usted no es apto para el credito");
                }
                Console.WriteLine("Quiere Ingresar otro usuario?");
                respuesta = Console.ReadLine().ToLower();
            }
            while (respuesta == "si");
            {
                Console.WriteLine($"La cantidad de usuarios a la que se le pregunto fue:{contador}");
                promedio = acumulado / contador;
                Console.WriteLine($"El promedio en los saldos fue:{promedio}");
            }
        }
    }
}
