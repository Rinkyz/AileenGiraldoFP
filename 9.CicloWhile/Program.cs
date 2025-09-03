namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado ppor el usuario.

            int contador = 0;
            int acumulador = 0:

            while (contador <= 5)
            {
                acumulador += contador; 
                Console.WriteLine($"C: {contador} - A: {acumulador}");
                contador++;
            }
            Console.WriteLine($"La cuma de los 5 primeros números enteros es: {acumulador}");
        }
    }
}
