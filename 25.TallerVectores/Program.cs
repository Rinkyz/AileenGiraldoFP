using System.Drawing;
using System.Net;

namespace _25.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
              encuentre y muestre el valor máximo y mínimo de los números ingresados.

            int[] numeros = new int[5];

            int mayor;
            int menor;

            mayor = numeros[0];
            menor = numeros[0];


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posición {i + 1}, con índice {i}");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"P: {i + 1} -I: {i}: {numeros[i]}");

                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine($"El valor máximo es: {mayor} - El valor mínimo es: {menor}");

            2. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
            orden de los elementos del vector.Se deben mostrar lo dos vectores. */

            char[] caracteres = new char[9];

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posición {i + 1}, con índice {i}");
                caracteres[i] = char.Parse(Console.ReadLine());

                Console.WriteLine($"P: {i + 1} -I: {i}: {caracteres[i]}");
            }


        }
    }
}
