namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ventas;

            float promedioanual = 0f;            
            int acumulador = 0;            
            int mesmayor = 0;
            int mesmenor = 0;            
            

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Ingrese el número de ventas en el mes #{i + 1}");
                ventas = Int32.Parse( Console.ReadLine() );
                
                if(ventas > acumulador - ventas)
                {
                    mesmayor = i + 1;
                }
                else
                {
                    mesmenor = i + 1;                    
                }

                acumulador += ventas;
            }

            Console.WriteLine($"Mayor: Mes#{mesmayor}, Menor: Mes#{mesmenor}");

            promedioanual = acumulador / 12;
            
            if(promedioanual <= 500)
            {
                Console.WriteLine($"El promedio anual de ventas es de {promedioanual}. La meta de ventas no se cumplió");
            }
            else
            {
                Console.WriteLine($"El promedio anual de ventas es de {promedioanual}. Se aprobó la meta");
            }

        }
    }
}
