namespace Edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            Console.WriteLine("Por favor ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >=18)
            { 
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No puedes entrar a este sitio web");
            }
        }
    }
}
