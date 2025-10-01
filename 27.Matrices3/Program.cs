using System.Runtime.ConstrainedExecution;

namespace _27.Matrices3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Solicita al usuario que ingrese las dimensiones de una matriz(número de filas y columnas). 
            Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
            Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, cuántos son negativos y cuántos son ceros.
            Finalmente, muestra por pantalla los totales obtenidos para cada categoría(positivos, negativos y ceros). */

            int filas = 0;
            int columnas = 0;
            int[,] numero = new int[filas, columnas];
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            Console.WriteLine("Ingrese el número de filas");
            filas = int.Parse(Console.ReadLine());            

            Console.WriteLine("Ingrese el número de columnas");
            columnas = int.Parse(Console.ReadLine());

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Digite el número para almacenarlo en la posición con índices {i}, {j} de la primera matriz");
                    numero[i, j] = Int32.Parse(Console.ReadLine());

                    if (numero[i, j] > 0)
                    {
                        positivos++;
                    }
                    if (numero[i, j] < 0)
                    {
                        negativos++;
                    }
                    if (numero[i, j] == 0)
                    {
                        ceros++;
                    }
                }
            }

            Console.WriteLine("La matriz queda asi:");

            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    Console.Write($"{numero[i, j]}     |");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Positivos: {positivos} - Negativos: {negativos} - Iguales a cero: {ceros}");
        }
    }
}
