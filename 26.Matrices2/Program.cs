namespace _26.Matrices2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que realice la suma de dos matrices de dimensiones 2x3. 
              Requisitos del programa:

              Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas. 
              Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3). 
              Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices. 
              Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas). */

            int[,] numeros1 = new int[2, 3];
            int[,] numeros2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            int acumulador = 0;

            //Ingresa los numeros en ambas matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Digite el número para almacenarlo en la posición con índices {i}, {j} de la primera matriz");
                    numeros1[i, j] = Int32.Parse(Console.ReadLine());
                } 
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Digite el número para almacenarlo en la posición con índices {i}, {j} de la segunda matriz");
                    numeros2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            //Se muestran los datos de cada matriz
            //Matriz 1
            for (int i = 0; i < numeros1.GetLength(0); i++)
            {
                for (int j = 0; j < numeros1.GetLength(1); j++)
                {
                    Console.WriteLine($"El número almacenado en la posición {i}, {j}: {numeros1[i, j]}");
                }
            }
            for (int i = 0; i < numeros1.GetLength(0); i++)
            {
                for (int j = 0; j < numeros1.GetLength(1); j++)
                {
                    Console.Write($"{numeros1[i, j]}     |");
                }
                Console.WriteLine();
            }
            //Matriz 2
            for (int i = 0; i < numeros2.GetLength(0); i++)
            {
                for (int j = 0; j < numeros2.GetLength(1); j++)
                {
                    Console.WriteLine($"El número almacenado en la posición {i}, {j}: {numeros2[i, j]}");
                }
            }
            for (int i = 0; i < numeros2.GetLength(0); i++)
            {
                for (int j = 0; j < numeros2.GetLength(1); j++)
                {
                    Console.Write($"{numeros2[i, j]}     |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("La suma de ambas matrices es:");

            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    Console.Write($"{numeros1[i,j] + numeros2[i,j]}     |");
                }
                Console.WriteLine();
            }
        }
    }
}
