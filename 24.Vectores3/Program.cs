namespace _24.Vectores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            float acumulador = 0;
            float promedio = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posición {i + 1}, con índice {i}");
                numeros[i] = int.Parse(Console.ReadLine());
                acumulador += numeros[i];

                Console.WriteLine($"P: {i + 1} -I: {i}: {numeros[i]}");
            }

            promedio = acumulador / 10;

            Console.WriteLine($"el promedio de los números ingresados en el arreglo es: {promedio}");
        }
    }
}
