namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir
              El algoritmo debe escribir en pantalla:
              1.La cantidad de numeros introducidos que son mayores que 0
              2. La cantidad de numeros introducidos menores que 0
              3. La cantidad de numeros iguales a 0*/

            int cantnum = 0;
            int num = 0;
            int contador = 1;
            int CantNumMen = 0;
            int CantNumMay = 0;
            int CantNumIg = 0;

            Console.WriteLine("Ingrese la cantidad de numeros que desea introducir");
            cantnum = Int32.Parse(Console.ReadLine());

            while (contador <= cantnum)
            {
                Console.WriteLine("Introduzca un número");
                num = Int32.Parse(Console.ReadLine());
                                
                if (num < 0)
                {
                    CantNumMen++;
                }

                if (num > 0)
                {
                    CantNumMay++;
                }
                            
                if(num == 0)
                {
                    CantNumIg++;
                }
                contador++;
            }

            Console.WriteLine($"Números introducidos: {cantnum} - Cantidad de números menores a 0: {CantNumMen} - Cantidad de números mayores a 0: {CantNumMay} - Cantidad de numeros iguales a 0: {CantNumIg}");
        }
    }
}
