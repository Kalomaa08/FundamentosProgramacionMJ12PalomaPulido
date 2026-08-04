using System;


namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numéricos
            // Incremento decremento 
            int dato1 = 0;
            dato1++; //dato1= dato1 + 1, incremento en 1 unidad 
            dato1--; // dato1 = dato1 -1, decremento en 1 unidad 
            dato1 += 15; //dato1 = dato1 + 15;
            dato1 -= 14; // dato1 = dato1 - 14;
            dato1 *= 3; // dato1 = dato1 * 3;
            dato1 /= 2; // dato1 = dato1 / 2;
            dato1 *= dato1;

            //Orden de evaluacion de opradores aritmeticos 
            int dato2 = 4 * 3 / 2;
            int dato3 = 5 / 3 * 2;
            int dato4 = 4 * (5 / 2);
            int dato5 = 3 - 1 *(4 / 2;
            Console.WriteLine(dato2);

            //Operadores Logicos 
            //Conjuncion - and - Y - &&
            Console.WriteLine("TABLA DE CONJUNCION");
            Console.WriteLine("V && V =" +(true&&true));
            Console.WriteLine("V && F =" +(true && false));
            Console.WriteLine("F && V=" +(false && true));
            Console.WriteLine("F && F= "+ (false && false));

            //Disyuncion -OR - O - ||
            Console.WriteLine("TABLA DE DISYUNCION");
            Console.WriteLine("V || V ="+(true || true));
            Console.WriteLine("V || F =" + (true || false));
            Console.WriteLine("F || V =" + (false || true));
            Console.WriteLine("F || F =" + (false || false));

            //Negacion 
            bool dato6 = true;
            bool dato7 = !dato6;


            //Operadores de comparacion 
            bool dato8 = 5 > 4;
            bool dato9 = 1002 == 102;
            bool dato10 = 10 >= 9;
            bool dato11 = 0 != 1; // != diferente 
            bool dato12 = 4 < 5 && 3 == 0;
            bool dato13 = 0 != 2 && dato8 || dato9; 



        }
    }
}
