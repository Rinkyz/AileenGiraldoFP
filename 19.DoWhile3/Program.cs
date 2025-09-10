namespace _19.DoWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            string género = "";
            int contadormujer = 0;
            int contadorhombre = 0;
            int contadormayor = 0;
            int contadormenor = 0;
            int estudiantes = 0;

            do
            {
                estudiantes++;

                Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su género. m:mujer, h:hombre");
                género = Console.ReadLine().ToLower();

                if (edad >= 18)
                {
                    contadormayor++;
                }
                else
                {
                    contadormenor++;
                }

                if (género == "m")
                {
                    contadormujer++;
                }
                if (género == "h")
                {
                    contadorhombre++;
                }

            } while (estudiantes < 5);

            Console.WriteLine($"Mayores de edad: {contadormayor}, Menores de edad: {contadormenor}, Hombres: {contadorhombre}, Mujeres: {contadormujer}");
        }
    }
}
