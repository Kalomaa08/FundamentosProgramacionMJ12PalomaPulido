using System;

namespace _TallerProgramacionModularReal
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string palabra = "";
                char[] vectorCaracteres = null;
                int opcion = 0;

                do
                {
                    MostrarMenu();
                    opcion = CapturarOpcion();
                    RealizarOperaciones(opcion, ref palabra, ref vectorCaracteres);
                } while (opcion != 0);
            }

            static string IngresarPalabra()
            {
                Console.WriteLine("Ingrese una palabra:");
                return Console.ReadLine() ?? string.Empty;
            }

            static char[] ConvertirAVector(string palabra)
            {
                if (string.IsNullOrEmpty(palabra))
                {
                    Console.WriteLine("Primero debe ingresar una palabra.");
                    return null;
                }
                char[] vector = palabra.ToCharArray();
                Console.WriteLine("¡Palabra convertida a vector de caracteres con éxito!");
                return vector;
            }

            static void ContarVocalesConsonantes(char[] vector)
            {
                if (vector == null || vector.Length == 0)
                {
                    Console.WriteLine("Primero debe ingresar y convertir una palabra a vector.");
                    return;
                }

                int vocales = 0;
                int consonantes = 0;
                string v = "aeiouáéíóúAEIOUÁÉÍÓÚ";

                foreach (char c in vector)
                {
                    if (char.IsLetter(c))
                    {
                        if (v.Contains(c.ToString ()))
                            vocales++;
                        else
                            consonantes++;
                    }
                }

                Console.WriteLine($"Cantidad de vocales: {vocales}");
                Console.WriteLine($"Cantidad de consonantes: {consonantes}");
            }

            static void RealizarOperaciones(int opcion, ref string palabra, ref char[] vectorCaracteres)
            {
                switch (opcion)
                {
                    case 1:
                        palabra = IngresarPalabra();
                        break;
                    case 2:
                        vectorCaracteres = ConvertirAVector(palabra);
                        break;
                    case 3:
                        ContarVocalesConsonantes(vectorCaracteres);
                        break;
                    case 0:
                        Console.WriteLine("SALIR");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            static int CapturarOpcion()
            {
                return int.Parse(Console.ReadLine());
            }

            static void MostrarMenu()
            {
                Console.WriteLine("-------------- Menú Palabra --------------");
                Console.WriteLine("1. Ingresar palabra     2. Convertir a vector");
                Console.WriteLine("3. Contar vocales/consonantes");
                Console.WriteLine("0. Salir");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Ingrese una opción del menú:");
            }
        }
    }