using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de Control Condicionales 
            //Simples 
            //1. Crea un algoritmo que lea la edad si el usuario es mayor de 18 años, se debe mostrar el siguiente mensaje:"Bienvenido a mi sitio web".
            /* byte edad = 0;
             Console.WriteLine("Ingrese la edad");
             edad = Convert.ToByte(Console.ReadLine());
             if (edad >= 18)
             {
                 //si la condicion se cumple 
                 Console.WriteLine("Bienvenido a mi sitio web");
             }*/
            //Crear un Algoritmo que permita ingresar el nombre y el suedo de una persona, si el sueldo supera 3000 pesos: mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impoestos.

            /*float Sueldo = 0;
            String Nombre;
            Console.WriteLine(" Ingrese sueldo");
            Sueldo = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese Nombre");
            Nombre = Console.ReadLine();
            if (Sueldo >= 3000) ;
            Console.WriteLine("Usted"+Nombre+ "Pague Impuestos");*/

            byte edad = 0;
            Console.WriteLine("Ingrese la edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //si la condicion se cumple 
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                //Si no cumple la condicion
                Console.WriteLine("No es apto para el contenido de este sitio web");

            }


        }
    }
}

