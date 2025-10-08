namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz = new float[6, 5];
            int marketing = 0;
            char[,] departamentos = new char[6, 5];
            float acumulador = 0;

            departamentos[0, 0] = ["Marketing", "Salario"];
            departamentos[0, 1] = ["Marketing", "Suministros"]


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Digite los gastos para {departamentos[i,j]}");
                    matriz[i, j] = float.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz queda asi:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{departamentos[i, j]}     |");
                    Console.Write($"{matriz[i, j]}     |");
                }
                Console.WriteLine();
            }
        }
    }
}
