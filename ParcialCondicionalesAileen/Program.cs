namespace ParcialCondicionalesAileen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            char Sala = ' ';
            char Juego = ' ';
            int precio = 0;

            Console.WriteLine("Ingrese su edad");

            edad = Int32.Parse(Console.ReadLine());

            if(edad >= 1 && edad <= 5)
            {
                
                Console.WriteLine("Puedes ingresar a la Sala 1. Los juegos disponibles son; 1:Juego 1, 5:Juego 5");
                Juego = Convert.ToChar(Console.ReadLine());

                switch (Juego)
                {
                    case '1':

                        precio = 3000;

                         Console.WriteLine($"Edad: {edad}, Sala: Sala 1, Juego: Juego 1, Precio a pagar: {precio}");

                        break;
                    case '5':

                        precio = 7000;

                         Console.WriteLine($"Edad: {edad}, Sala: Sala 1, Juego: Juego 5, Precio a pagar: {precio}");

                        break;
                    default:
                        Console.WriteLine("Debes ingresar un valor válido");
                        break;
                }
            }
            if(edad >= 6 && edad <= 16)
            {
                
                Console.WriteLine("Puedes ingresar a la Sala 2. Los juegos disponibles son; 3:Juego 3, 6:Juego 6");
                Juego = Convert.ToChar(Console.ReadLine());

                switch (Juego)
                {
                    case '3':

                        precio = 7000;

                        Console.WriteLine($"Edad: {edad}, Sala: Sala 2, Juego: Juego 3, Precio a pagar: {precio}");

                        break;
                    case '6':

                        precio = 9000;

                        Console.WriteLine($"Edad: {edad}, Sala: Sala 2, Juego: Juego 6, Precio a pagar: {precio}");

                        break;
                    default:
                        Console.WriteLine("Debes ingresar un valor válido");
                        break;
                }
            }
            if (edad >= 17 && edad <= 25)
            {                
                Console.WriteLine("Puedes ingresar a la Sala 3 y 4, ¿A cual deseas ingresar? s:Sala 3, f:Sala 4");
                Juego = Convert.ToChar(Console.ReadLine());
                Sala = Convert.ToChar(Console.ReadLine());

                switch (Sala)
                {
                    case 's':

                        Console.WriteLine("Los juegos disponibles son; 2:Juego 2, 7:Juego 7");

                        switch (Juego)
                        {
                            case '2':

                                precio = 5000;

                                Console.WriteLine($"Edad: {edad}, Sala: Sala 3, Juego: Juego 2, Precio a pagar: {precio}");

                                break;
                            case '7':

                                precio = 10000;

                                Console.WriteLine($"Edad: {edad}, Sala: Sala 3, Juego: Juego 7, Precio a pagar: {precio}");

                                break;
                            default:
                                Console.WriteLine("Debes ingresar un valor válido");
                                break;
                        }
                        break;
                    case 'f':

                        Console.WriteLine("Los juegos disponibles son; 4:Juego 4, 8:Juego 8");
                        Juego = Convert.ToChar(Console.ReadLine());

                        switch (Juego)
                        {
                            case '4':

                                precio = 9000;

                                Console.WriteLine($"Edad: {edad}, Sala: Sala 4, Juego: Juego 4, Precio a pagar: {precio}");

                                break;
                            case '8':

                                precio = 7000;

                                Console.WriteLine($"Edad: {edad}, Sala: Sala 4, Juego: Juego 8, Precio a pagar: {precio}");

                                break;
                            default:
                                Console.WriteLine("Debes ingresar un valor válido");
                                break;
                        }
                        break;                                                
                    default:
                        Console.WriteLine("Debes ingresar un valor válido");
                        break;
                }
                                
            }
            if(edad >= 26)
            {
                Console.WriteLine("Puedes ingresar a la Sala 5. Los juegos disponibles son; 9:Juego 9, t:Juego 10");
                Juego = Convert.ToChar(Console.ReadLine());

                switch (Juego)
                {
                    case '9':

                        precio = 5000;

                        Console.WriteLine($"Edad: {edad}, Sala: Sala 5, Juego: Juego 9, Precio a pagar: {precio}");

                        break;
                    case 't':

                        precio = 3000;

                        Console.WriteLine($"Edad: {edad}, Sala: Sala 5, Juego: Juego 10, Precio a pagar: {precio}");

                        break;
                    default:
                        Console.WriteLine("Debes ingresar un valor válido");
                        break;
                }
            }

        }
    }
}
