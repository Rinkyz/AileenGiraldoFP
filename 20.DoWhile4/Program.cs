namespace _20.DoWhile4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int partidos = 0;
            string status;
            int ganados = 0;
            int perdidos = 0;
            int empatados = 0;
            int contador = 30;
            Double promediowin = 0;
            Double promediolose = 0;
            Double promediotie = 0;

            do
            {
                partidos++;
                Console.WriteLine($"Partido #{partidos}");
                Console.WriteLine("Ingrese el status del partido. g:ganado, p:perdido, e:empatado");
                status = Console.ReadLine().ToLower();

                if(status == "g")
                {
                    ganados++;                   
                }
                if (status == "p")
                {
                    perdidos++;
                }
                if (status == "e")
                {
                    empatados++;
                }

                promediowin = (ganados*100)/contador;
                promediolose = (perdidos*100)/contador;
                promediotie = (empatados*100)/contador;

            } while (partidos < contador);

            Console.WriteLine($"Partidos ganados: {ganados}, Partidos perdidos: {perdidos}, Partidos empatados: {empatados}");
            Console.WriteLine($"Promedio de partidos ganados: {promediowin}%");
            Console.WriteLine($"Promedio de partidos perdidos: {promediolose}%");
            Console.WriteLine($"Promedio de partidos empatados: {promediotie}%");
        }
    }
}
