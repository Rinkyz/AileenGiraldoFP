namespace InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la declaración e inicialización de una variable
            string nombre="Aileen";
            const string iva="19%";

            Console.WriteLine("Hola, " + nombre + "\n");
            Console.WriteLine("\tBienvenido a la clase de programación");
            nombre = "David";
            Console.WriteLine("\n" + nombre);
            //iva = "20%"; No se puede cambiar el valor de una constante

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = 2839283;
            long dato3 = 1234567890987654321;
            double dato4 = 346.232;
            char dato5 = 'w'; // puede almacenar un solo caracter
            bool dato6 = false; //Almacena true o false
            object dato7 = new Program(); 
        }
    }
}
