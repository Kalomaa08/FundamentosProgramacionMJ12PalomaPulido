using System;

namespace Parcial2ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int promedio1 = 0;
            int Exa1 = 0;
            int Exa2 = 0;
            int investigacion = 0;
            int promedio2 = 0;
            int aprobados = 0;
            int reprobados = 0;
            int promedio3= 0;

            for (int contador = 1; contador <= 25 ;)
            {
                contador++;

                Console.WriteLine("ingrese la nota del Examen 1 entre 0.0 y 5.0");
                Exa1 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota del Examen 2 0.0 y 5.0");
                Exa2 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota del Trabajo de Investigacion 0.0 y 5.0");
                investigacion = int.Parse(Console.ReadLine());

                promedio1 = ((Exa1 + Exa2 + investigacion) / 3);
                promedio2 += promedio1;

                if (promedio1 >= 3.5)
                {
                    Console.WriteLine("Aprobó");
                    aprobados++;
                }
                else
                {
                    Console.WriteLine("Reprobó");
                    reprobados++;
                }
                promedio3 = promedio2 / 25;
            }

            Console.WriteLine($"Estudiantes Aprobados ={aprobados}");
            Console.WriteLine($"Estudiantes Reprobados ={reprobados}");
            Console.WriteLine($"El promedio del Salon ={promedio3}");

        }
    }
}
    

