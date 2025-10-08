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

            /* Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
              caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
              primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
              matriz con el intercambio de filas.

               int n, m;

               Console.Write("Ingrese el número de filas que desee ingresar: ");
               n = int.Parse(Console.ReadLine());

               Console.Write("Ingrese el número de columnas que desee ingresar: ");
               m = int.Parse(Console.ReadLine());

               char[,] matriz = new char[n, m];

               Console.WriteLine("Ingrese los caracteres para llenar la matriz:");
               for (int i = 0; i < n; i++)
               {
                   for (int j = 0; j < m; j++)
                   {
                       Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                       matriz[i, j] = char.Parse(Console.ReadLine());
                   }
               }

               Console.WriteLine("\nMatriz Original:");
               ImprimirMatriz(matriz, n, m);

               // Intercambio de la primera y la última fila
               for (int j = 0; j < m; j++)
               {
                   char temp = matriz[0, j];
                   matriz[0, j] = matriz[n - 1, j];
                   matriz[n - 1, j] = temp;
               }

               Console.WriteLine("\nMatriz con la primera y última fila intercambiadas:");
               ImprimirMatriz(matriz, n, m);


           static void ImprimirMatriz(char[,] matriz, int filas, int columnas)
           {
               for (int i = 0; i < filas; i++)
               {
                   for (int j = 0; j < columnas; j++)
                   {
                       Console.Write(matriz[i, j] + " ");
                   }
                   Console.WriteLine();
               }
           }*/

            /*Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
              5x5 llena de números aleatorios. 
              El algoritmo debe permitir: 
                 Usa la función Random para generar los números aleatorios. 
                 Crea un arreglo adicional para almacenar la frecuencia de cada número. 
                 Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número 

            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int[10];
            Random rand = new Random();
            // Llenar la matriz con números aleatorios del 1 al 10 y contar la frecuencia
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(1, 11); // Números aleatorios entre 1 y 10
                    frecuencia[matriz[i, j] - 1]++; // Incrementar la frecuencia del número
                }
            }
            // Mostrar la matriz
            Console.WriteLine("Matriz 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Mostrar la frecuencia de cada número del 1 al 10
            Console.WriteLine("\nFrecuencia de cada número del 1 al 10:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencia[i]} veces");
            }*/

            /*Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en 
              posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la 
              posición de una "X". 
              El algoritmo debe permitir: 
                 Usar la función Random para colocar las "X" en la matriz. 
                 Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 
                 Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la 
                  posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. 
            char[,] tablero = new char[5, 5];
            Random rand = new Random();
            // Colocar 3 "X" en posiciones aleatorias
            int xCount = 0;
            while (xCount < 3)
            {
                int fila = rand.Next(0, 5);
                int columna = rand.Next(0, 5);
                if (tablero[fila, columna] != 'X')
                {
                    tablero[fila, columna] = 'X';
                    xCount++;
                }
            }
            // Permitir 3 intentos al usuario
            bool acertado = false;
            for (int intento = 1; intento <= 3; intento++)
            {
                Console.Write($"Intento {intento}: Ingrese la fila (0-4): ");
                int filaUsuario = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la columna (0-4): ");
                int columnaUsuario = int.Parse(Console.ReadLine());
                if (filaUsuario < 0 || filaUsuario > 4 || columnaUsuario < 0 || columnaUsuario > 4)
                {
                    Console.WriteLine("Coordenadas fuera de rango. Intente de nuevo.");
                    intento--; // No contar este intento
                    continue;
                }
                if (tablero[filaUsuario, columnaUsuario] == 'X')
                {
                    acertado = true;
                    Console.WriteLine($"¡Felicidades! Has acertado la posición de una 'X' en ({filaUsuario}, {columnaUsuario}).");
                    break;
                }
                else
                {
                    Console.WriteLine("No has acertado. Intenta de nuevo.");
                }
            }
            if (!acertado)
            {
                Console.WriteLine("Lo siento, no has acertado ninguna 'X'. Aquí está el tablero:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j] == 'X' ? 'X' : '.'); // Mostrar 'X' o '.' para espacios vacíos
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }*/

            /*Desarrollar un programa e C# que: 
                 Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz 
                  de enteros 
                 Cargue los datos de la matriz ingresándolos por teclado  
                 Muestre la matriz ingresada 
                 Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser 
                  ahora la columna 1. 
                 Mostrar la nueva matriz 

            int n, m;
            Console.Write("Ingrese el número de filas que desee ingresar: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas que desee ingresar: ");
            m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            Console.WriteLine("Ingrese los elementos para llenar la matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatriz Original:");
            ImprimirMatriz(matriz, n, m);
            // Convertir filas en columnas
            int[,] matrizTranspuesta = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrizTranspuesta[j, i] = matriz[i, j];
                }
            }
            Console.WriteLine("\nMatriz Transpuesta (filas convertidas en columnas):");
            ImprimirMatriz(matrizTranspuesta, m, n);
            static void ImprimirMatriz(int[,] matriz, int filas, int columnas)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }*/

            /*Crear una aplicación en C# que permita realizar las siguientes acciones: 
                 Crear una matriz de n filas por m columnas 
                 Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#) 
                 Mostrar la matriz generada 
                 Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el 
                  número 3, y cuál de los tres números fue repetido más veces.
            int n, m;
            Console.Write("Ingrese el número de filas que desee ingresar: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas que desee ingresar: ");
            m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            int[] frecuencia = new int[3];
            Random rand = new Random();
            // Llenar la matriz con números aleatorios del 1 al 3 y contar la frecuencia
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 4); // Números aleatorios entre 1 y 3
                    frecuencia[matriz[i, j] - 1]++; // Incrementar la frecuencia del número
                }
            }
            // Mostrar la matriz
            Console.WriteLine("\nMatriz generada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Mostrar la frecuencia de cada número del 1 al 3
            Console.WriteLine("\nFrecuencia de cada número del 1 al 3:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencia[i]} veces");
            }
            // Determinar cuál número fue repetido más veces
            int maxFrecuencia = frecuencia[0];
            int numeroMasRepetido = 1;
            for (int i = 1; i < 3; i++)
            {
                if (frecuencia[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencia[i];
                    numeroMasRepetido = i + 1;
                }
            }
            Console.WriteLine($"\nEl número que fue repetido más veces es el {numeroMasRepetido} con {maxFrecuencia} repeticiones.");*/
        }
    }
}
