namespace _4._CondicionalDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos
            mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. 
            De lo contrario, mostrar el mensaje "Persona exenta de impuestos". */

            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine(); 

            Console.WriteLine(nombre);
            Console.WriteLine("Ingrese el sueldo");

            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //Verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona {nombre}, no debe abonar impuestos");
            }

            int edad = 0;
            Console.WriteLine("Por favor ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
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
