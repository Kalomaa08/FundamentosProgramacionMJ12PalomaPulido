using System;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            Console.WriteLine("Nombre del Empleado");
            Nombre = (Console.ReadLine());
            int AEmpresa;
            Console.WriteLine("Numero de años dentro de la empresa");
            AEmpresa = int.Parse(Console.ReadLine());
            double Cactual;
            Console.WriteLine("Calificacion de este año");
            Cactual = double.Parse(Console.ReadLine());
            double Cpasada;
            Console.WriteLine("Calificacion del año pasado");
            Cpasada = double.Parse(Console.ReadLine());

            if (Cactual == 0.0 || Cactual == 0.4 || Cactual == 0.6 || Cactual == 1.0 && Cpasada == 0.0 || Cactual == 0.4 || Cactual == 0.6 || Cactual == 1.0)
            {
                double Promed = (Cactual + Cpasada) / 2;
                double PorcenAumen = 0;

                if (AEmpresa == 0)
                {
                    PorcenAumen = 0;
                }
                else if (AEmpresa > 5)
                {
                    PorcenAumen = 30;
                }
                else
                {
                    if (Promed >= 0.0 && Promed < 0.4)
                    {
                        PorcenAumen = 5;
                    }
                    else if (Promed >= 0.4 && Promed < 0.6)
                    {
                        PorcenAumen = 10;
                    }
                    else if (Promed >= 0.6 && Promed <= 1.0)
                    {
                        PorcenAumen = 20;
                    }
                }
                double SueldoBase = 2500000;
                double ValorAumen = SueldoBase * (PorcenAumen / 100);
                Console.WriteLine("Resultados");
                Console.WriteLine("Nombre del empleado: " + Nombre);
                Console.WriteLine("Promedio de calificación: " + Promed);
                Console.WriteLine("Porcentaje de aumento: " + PorcenAumen);
                Console.WriteLine("Valor del aumento en pesos: " + ValorAumen);
            }
            else
            {
                Console.WriteLine("Error: calificación inválida. El programa terminará.");
            }
        }
    }
}


