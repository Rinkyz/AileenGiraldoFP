namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al numero n

            int rango = 0;
            int contador = 1;
            int cantidadPares = 0;
           
            Console.WriteLine("Ingrese el rango de números a evaluar");
            rango = Int32.Parse(Console.ReadLine());

            while (contador <= rango)

            {
                if(contador%2 == 0)
                {                    
                    cantidadPares++;
                }
                contador++;
            }

            Console.WriteLine($"Pares en el rango 1 - {rango} = {cantidadPares}");
        }
    }
}
