namespace _11.While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;            
            int num = 0;

          
            while (num >= 0)
            {
                contador += num;

                Console.WriteLine("Porfavor ingrese un número entero positivo");
                num = Int32.Parse(Console.ReadLine());

            }
            Console.WriteLine($"La suma es {contador}");

        }
    }
}