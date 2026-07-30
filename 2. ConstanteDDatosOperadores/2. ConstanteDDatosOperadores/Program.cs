using System;
using System.ComponentModel;

namespace _2.ConstanteDDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constantes
            const string gravedad = "9.8";
            string nombre = "paloma";
            //gravedad = "10"; no puedo cambiar el nombre de una constante 

            //TIPOS DE DATOS
            byte dato1 = 0;// hasta 255
            int dato2 = -4563;// entero con signo 
            ulong dato3 = 29283476293847;// entero + mas grande 
            float dato4 = 14.6f;// poner f al final para no errores 
            double dato5 = 1232345.2348978798d;// decimal grande opcional sufijo d
            decimal dato6 = 1232432343454356345.987877657623871263m; //sufijo m para decimal 

            char dato7 = '5';//un solo caracter y comillas simples 
            string dato8 = "4 lol * ~";//cualquier caracter
            bool dato9 = false;//solo verdadero y falso 
            object dato10 = new object(); //clase de la cual el resto vienen 

            //OPERADORES operadores numericos (cambio de signo)
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0}, dato12:{1}, dato13:{2}, dato14:{3}", dato11, dato12, dato13, dato14);
            
            //aritmeticos
            int dato15 = 5 + 3;//suma
            int dato16 = dato15 - 2;// resta
            int dato17 = 25 * 3; //multiplicacion 
            float dato18 =(float) 5 / 3;// divicion 
            Console.WriteLine("suma:{0}, resta:{1}, producto:{2}, division:{3}", dato15, dato16, dato17, dato18);

        }
    }
}
