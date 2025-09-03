namespace _10._While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario.

            int num = 0;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese un número");
            num = Int32.Parse(Console.ReadLine());
            
            while ( contador <= num)
            {
                acumulador *= contador;
                Console.WriteLine($"Contador: {num} - Factorial: {acumulador}");
                contador++;
            }

            Console.WriteLine($"La factorial de {num} es: {acumulador}");
        }
    }
}
