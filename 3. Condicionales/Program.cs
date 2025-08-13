namespace _3._Condicionales
{
   
    internal class Program
    {        
        static void Main(string[] args)
        {
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine(); //Todo lo que leo desde la consola
            //Llega como un STRING
            Console.WriteLine(nombre);
            Console.WriteLine("Ingrese el sueldo");

            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");

            }
            else
            {
                Console.WriteLine($"La persona {nombre}, no debe abonar impuestos");
            }
        }
    }
}
