using System;
namespace Lab6Ejemplos
{
    // estructuras
    public struct Point { public int X, Y; }

    public class Program4
    {
        public static void Main4(string[] args)
        {
            Console.WriteLine("Program 4");
            // Crear y dimensionar un arreglo
            int[] pares = new int[4];
            // Inicializar el arreglo
            pares[0] = 2;
            pares[1] = 4;
            pares[2] = 6;
            pares[3] = 8;
            // Leer el arreglo
            Console.WriteLine("Pares:");
            for (int j = 0; j < pares.Length; j++)
            {
                Console.Write(pares[j] + " ");
            }

            // Arreglo de impares
            int[] impares = { 1, 3, 5, 7, 9, 11 };
            Console.WriteLine("\nImpares:");
            for (int j = 0; j < impares.Length; j++)
            {
                Console.Write(impares[j] + " ");
            }

            //Arreglo de objetos de una estructura
            Point[] puntos = new Point[10];
            puntos[0].X = 12;
            puntos[0].Y = 50;
            Console.WriteLine($"\nPuntos {puntos[0]}");
            Console.WriteLine($"\nPrimer Punto {puntos[0].X},{puntos[0].Y}");

            // Arreglo de objetos de una clase
            Customer[] clientes = new Customer[3];
            clientes[0] = new Customer("Juan Perez", "direccion1", "telefono1");
            clientes[1] = new Customer("Raul Aguilar", "direccion2", "telefono2");
            clientes[2] = new Customer("Sandra Sanchez", "direccion3", "telefono3");

            Console.WriteLine($"\n Ultimo cliente {clientes[2].Imprimir()}");

            // Arreglos bidimensionales
            int[,] matriz = new int[6, 6];

            // Crear un codigo que coloque un 1 en la diagonal
            // Imprimir matriz
            for (int r = 0; r < matriz.GetLength(0); r++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if (c == r)
                        matriz[r, c] = 1;
                }
            }

            // Imprimir matriz
            for (int r = 0; r < matriz.GetLength(0); r++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[r,c] + " ");
                }
                Console.WriteLine("");
            }






        }

    }
}


