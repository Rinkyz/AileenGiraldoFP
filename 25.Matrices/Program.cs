namespace _25.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arreglos bidimensionales - Matrices
            int[,] numeros = new int[2, 2]; //rango=fxc=2x2=4
                        
            bool[,] banderas = new bool[2, 5];
            object[,] objetos = new object[2, 5];

            //Asignación de valores con f,c

            numeros[0, 0] = 15;
            numeros[0, 1] = 25;
            numeros[1, 0] = 32;
            numeros[1, 1] = 4;
            //numeros[1, 2] = 7; Error por índices fuera de los rangos
            //Recuperar datos almacenados en una posición 

            Console.WriteLine($"Valor almacenado en la posición con índices 1, 0: {numeros[1, 0]}");

            //Declaración e inicialización de matrices con valores por defecto

            string[,] apellidos =
                {
                    {"Chica", "López", "Álvarez"},
                    {"Patiño", "Ciro", "Botero" },
                    {"Duque", "Carmona", "Castaño"}
                };

            Recorrer para almacenar datos

            string[,] nombres = new string[3, 2];

            for (int i = 0; i < 3; i++)//Recorrer las filas
            {
                for(int j = 0; j < 2; j++)//Recorrer las columnas
                {
                    Console.WriteLine($"Digite el nombre para almacenarlo en la posición con índices {i}, {j}");
                    nombres[i, j] = Console.ReadLine();
                    
                }
            }

            //Recorrer para recuperar los datos

            for(int i = 0;i < nombres.GetLength(0); i++)//.GetLength(0) devuelve el número de filas
            {
                for (int j = 0;j < nombres.GetLength(1); j++)//.GetLength devuelve el número de columnas
                {
                    Console.WriteLine($"Nombre almacenado en la posición {i}, {j}: {nombres[i,j]}");
                
                }
            }

            for (int i = 0; i < nombres.GetLength(0); i++)
            {
                for (int j = 0; j < nombres.GetLength(1); j++)
                {
                    Console.Write($"{nombres[i, j]}     |");
                }
                Console.WriteLine();
            }*/

            char[,] caracteres = new char[2, 4];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Digite el caracter para almacenarlo en la posición con índices {i}, {j}");
                    caracteres[i, j] = char.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < caracteres.GetLength(0); i++)
            {
                for (int j = 0; j < caracteres.GetLength(1); j++)
                {
                    Console.WriteLine($"Nombre almacenado en la posición {i}, {j}: {caracteres[i, j]}");
                }
            }
            for (int i = 0; i < caracteres.GetLength(0); i++)
            {
                for (int j = 0; j < caracteres.GetLength(1); j++)
                {
                    Console.Write($"{caracteres[i, j]}     |");
                }
                Console.WriteLine();
            }
        }
    }
}
