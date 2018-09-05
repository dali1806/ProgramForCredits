using System;

namespace TallerClase03_09_2018
{
        /* Owner Daniel Suescun
         * Date 04/09/2018
         * GitHub User dali1806
         * Description: This program is used for calculate cuotes of a credit.
         */
    class Program
    {
        static int pedirValor()
        {
            int x=0;
            bool comprobacion = true;
            do
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    comprobacion = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido a la aplicacion de calculo de cuotas.\n" +
                                  "Digite la opcion que desea realizar: \n" +
                                  "1. Calcular un prestamo\n" +
                                  "2. Salir");
                    Console.WriteLine("Digite un valor correcto: ");
                    comprobacion = false;
                }
            } while (comprobacion != true);
            return x;
        }


        static int[] llenarVector(int y, int x)
        {
            int i;
            int[] vector = new int[x];
            vector[0] = y;
            for (i = 1; i < x; i++)
            {
                vector[i] = vector[i - 1] * 2;
            }
            return vector;
        }


        static void desplegarVector(int[] vector, int x)
        {
            int i, acumulador=0;
            for (i = 0; i < x; i++)
            {
                Console.WriteLine(" " + vector[i]);
                acumulador = acumulador + vector[i];
            }
            Console.WriteLine("\nEl total es: " + acumulador);
        }




        static void Main(string[] args)
        {
            int cuotas = 0, cuotainicial = 0,opcion=0;
            Console.WriteLine("Bienvenido a la aplicacion de calculo de cuotas.\n" +
                                  "Digite la opcion que desea realizar: \n" +
                                  "1. Calcular un prestamo\n" +
                                  "2. Salir");
            opcion = pedirValor();
            Console.Clear();
            while (opcion != 2)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Digite el numero de cuotas a pagar: ");
                        cuotas = pedirValor();
                        int[] cantidadCuotas = new int[cuotas];
                        Console.WriteLine("Digite el valor de la cuota inicial: ");
                        cuotainicial = pedirValor();
                        cantidadCuotas = llenarVector(cuotainicial, cuotas);
                        desplegarVector(cantidadCuotas, cuotas);
                        break;
                    case 2:
                        Console.WriteLine("El programa finalizo con exito.");
                        break;
                    default:
                        Console.WriteLine("Bienvenido a la aplicacion de calculo de cuotas.\n" +
                                  "Digite la opcion que desea realizar: \n" +
                                  "1. Calcular un prestamo\n" +
                                  "2. Salir");
                        Console.WriteLine("Digite un valor correcto: ");
                        break;
                }
                opcion = pedirValor();
                Console.Clear();
            } 
        }
    }
}
