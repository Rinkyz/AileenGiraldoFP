namespace _7.OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador Ternario

            /* Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario. Una persona mayor de edad tiene 18 años o más)*/

            /*int edad = 0;

            Console.WriteLine("Ingrese la edad");
            edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "NO es mayor de edad");

            /*Algoritmo que permita ingresar 3 números enteros diferentes, y muestre un mensaje diciedo cuál es el mayor*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("Ingrese el primer número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            num3 = Int32.Parse(Console.ReadLine());

            mayor = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);

            Console.WriteLine($"El número mayor es {mayor}");
        }
    }
}
