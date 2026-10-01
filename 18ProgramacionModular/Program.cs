using System;

namespace _18ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de Programacíon");
            MostrarMensaje("Piyon");
            MostrarMensaje("Paloma", "Pulido Montoya");
            Console.WriteLine($"Valeria tiene {CalcularEdad()} ");
            Console.WriteLine($"Valeria tiene {CalcularEdad(2026, 2008)}");
            Console.ReadKey();
            BorrarPantalla();

        }
        //Procedimiento sin párametros 
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        //Funciones con parámetro
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
        
        //Funciones sin parámetros
        static int CalcularEdad()
        {
            int añoNacimiento = 2008;
            int añoActual = 2026;
            int edad= añoNacimiento - añoActual;
            return edad;
        }


        //Procedimiento con párametros 
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido {nombre} al curso de Fundamentos de Programacíon");
        }

        static void MostrarMensaje(string nombre, string apellidos)
        {
          Console.WriteLine($"Bienvenido {nombre} {apellidos} al curso de Fundamentos de Programacíon");
        }
        


    }
}
