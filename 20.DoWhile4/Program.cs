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

                promediowin = ganados*0.25;
                promediolose = perdidos * 0.25;
                promediotie = empatados * 0.25;

            } while (partidos < 4);

            Console.WriteLine($"Partidos ganados: {ganados}, Partidos perdidos: {perdidos}, Partidos empatados: {empatados}");
            Console.WriteLine($"Promedio de partidos ganados: {promediowin}");
            Console.WriteLine($"Promedio de partidos perdidos: {promediolose}");
            Console.WriteLine($"Promedio de partidos empatados: {promediotie}");
        }
    }
}
