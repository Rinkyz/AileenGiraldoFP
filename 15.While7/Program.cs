namespace _15.While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; 
            además, se quiere saber cuánto lleva ahorrado cada mes*/

            int ahorromes = 0;            
            int contador = 1;
            int acumulador = 0;
                      
            while (contador <= 12)
            {
                Console.WriteLine("Ingrese los ahorros que lleva en el mes");
                ahorromes = Int32.Parse(Console.ReadLine());
                                
                acumulador += ahorromes;
                Console.WriteLine($"Ahorro del mes {contador} es {acumulador}");
                contador++;
                                
            }

            Console.WriteLine($"Usted ahorrará un total de: {acumulador} en el año");
        }
    }
}
