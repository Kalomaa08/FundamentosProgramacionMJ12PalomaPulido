using System;

namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();

            RealizarOperaciones(CapturarOpcion());
        }

        static float Suma()
        {
            int numero = 0;
            int suma = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un núero");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea sumar más números. s: para continuar:");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }
        static float Multiplicacion()
        {
            int numero = 0;
            int multiplicacion = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un núero");
                numero = int.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea multiplicar más números. s: para continuar:");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }

        static float Resta()
        {

            Console.WriteLine("Ingrese el numero1 :");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2 :");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;
        }

        static float Division()
        {

            Console.WriteLine("Ingrese el numero1 :");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2 :");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }


        static void RealizarOperaciones(int opcion)
        {
            switch (opcion)
            {
               case 1:
                    Console.WriteLine($"La SUMA de los números ingresados es: {Suma()}");
                    break;
               case 2:
                 Console.WriteLine($"La resta de los números ingresados es: {Resta()}");
                    break;
               case 3:
                 Console.WriteLine($"La MULTIPLICACION de los números ingresados es: {Multiplicacion()}");
                    break;
               case 4:
                 Console.WriteLine($"La DIVISION de los números ingresados es: {Division()}");
                    break;
               case 0:
                 Console.WriteLine("SALIR");
                 break;

            }
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
            opcion = CapturarOpcion();
        }


        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());

        }
        static void MostrarMenu()
        {
            Console.WriteLine("--------------Menú-----------");
            Console.WriteLine("1.Suma              2.Resta");
            Console.WriteLine("3. Multiplicacion   4.Division");
            Console.WriteLine("0.Salir");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ingrese una opcióm del menú :");
        }
    }
}
