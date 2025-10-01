using System.Runtime.ConstrainedExecution;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.*/

            /*int[,] matriz = new int[10, 20];
            Random numero = new Random();
            int[] suma = new int [20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = numero.Next(1,10);
                    suma[j] += matriz[i, j];
                }
            }
            Console.WriteLine("Matriz: ");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write($"{matriz[i, j]} |");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int j = 0; j < 20; j++)
            {                
                Console.Write($"Suma de columna #{j + 1} es: {suma[j]}");
                Console.WriteLine();
            }
           */

            /*Desarrollar un programa que crea una matriz de n filas *m columnas, el usuario ingresa
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas.*/

            int filas = 0;
            int columnas = 0;            

            Console.WriteLine("Ingrese el número de filas");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas");
            columnas = int.Parse(Console.ReadLine());

            int[,] numero = new int[filas, columnas];
            int[,] invertido = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Digite el número para almacenarlo en la posición con índices {i}, {j} de la primera matriz");
                    numero[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz:");

            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    Console.Write($"{numero[i, j]}|");
                }
                Console.WriteLine();
            }

            Console.Write("Matriz invertida:");
            Console.WriteLine();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"I:{i}, {j}");
                }
                Console.WriteLine($"{invertido}");
            }
        }
    }
}
