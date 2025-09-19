using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System.Runtime.InteropServices;

namespace TallerParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Algoritmo que permita calcular el promedio de calificaciones, ele permitirá al usuario, introducir tantas calificaciones como así desee, 
              en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las 
              calificaciones capturadas previamente

            Double nota = 0;
            Double promedio = 0;
            string respuesta = "";
            Double acumulador = 0;
            int contador = 0;
           
            do
            {
                contador++;

                Console.WriteLine("Ingrese una calificación");
                nota = Double.Parse(Console.ReadLine());

                acumulador += nota;

               Console.WriteLine("¿Desea ingresar más calificaciones? s:si, n:no");
                respuesta = Console.ReadLine().ToLower();

               
            } while (respuesta == "s");

            promedio = acumulador / contador;
            Console.WriteLine($"El promedio es: {promedio}");

            /* Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado. 
               Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/b el 
               residuo es 0, en C# utilizar el operador Mod para obtener el residuo de una división de dos números. 
               Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 2, 1 que son los divisores del número 6

            int num = 0;
            int contador = 1;

            Console.WriteLine("Ingrese un número para saber cuales son sus divisores");
            num = int.Parse(Console.ReadLine());

            while (contador <= num)
            {
                if(num%contador == 0)
                {
                    Console.WriteLine($"{contador} es divisible por {num}");
                    
                }
                contador++;
            }

            /* Dados dos números enteros ingresados por teclado: b que es la base y e que es el exponente, se requiere calcular el resultado de la 
               potenciación. 
               Ejemplo: b=2, e=5  2=2*2*2*2*2= 32 
               Mostrar por pantalla el resultado de la potenciación. Seguir pidiendo por teclado la base y el exponente y realizar la 
               potenciación correspondiente, hasta que el usuario ingrese por teclado el carácter de escape ‘n’

            int num1 = 0;
            int num2 = 0;
            int acumulador = 1;
            int contador = 1;
            string respuesta = "";

            do
            {
                
                Console.WriteLine("Ingrese un número");
                num1 = Int32.Parse(Console.ReadLine());
                                
                Console.WriteLine("Ingrese un exponente");
                num2 = Int32.Parse(Console.ReadLine());

                while (contador <= num2)
                {
                    acumulador *= num1;

                    contador++;
                }

                Console.WriteLine($"El resultado es {acumulador}");

                Console.WriteLine("¿Desea ingresar otro número y calcular el exponente elegido? s:si, n:no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

             Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilómetros durante 10 días, para determinar si es apto para la prueba de
              5 kilómetros.Para considerarlo apto debe cumplir las siguientes condiciones: 
              - Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
              - Que al menos en una de las pruebas realice un tiempo menor de 15 minutos.
              - Que su promedio sea menor o igual a 18 minutos.
               Diseñar un algoritmo para registrar los datos y decidir si es apto para la competencia.*/

            float tiempo = 0f;
            float promedio = 0f;
            float acumulador = 0f;            
            int menorcontador = 0;

            for (int i = 0; i < 10; i++)
            {
                 Console.WriteLine("Ingrese el tiempo en minutos que le tomó realizar la ruta");
                 tiempo = float.Parse(Console.ReadLine());
                
                if(tiempo < 15)
                {                    
                    menorcontador++;
                }
                
                acumulador += tiempo;
            }

            promedio = acumulador/10;

            if(tiempo < 20 && menorcontador >= 1 && promedio <= 18)
            {
                Console.WriteLine("Es apto");
            }
            else
            {
                Console.WriteLine("No es apto");
            }
        }

    }
}
