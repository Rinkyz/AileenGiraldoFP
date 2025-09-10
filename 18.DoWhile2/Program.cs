namespace _18.DoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*18. Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
              - Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
              - Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
              
            El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */

            string nombre;
            int cuenta = 0;
            int saldo = 0;
            string respuesta;
            int usuarios = 0;
            int promedio = 0;

            do
            {
                usuarios++;

                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su número de cuenta");
                cuenta = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su saldo");
                saldo = Int32.Parse(Console.ReadLine());

                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}, Número de cuenta: {cuenta}, Saldo: {saldo} Es apto para el crédito");
                }

                if (saldo < 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}, Número de cuenta: {cuenta}, Saldo: {saldo} No es apto para el crédito");

                }


                Console.WriteLine("¿Desea ingresar más informacion de usuario? s:si, n:no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            promedio = saldo / usuarios;
            Console.WriteLine($"Número de usuarios: {usuarios}, Promedio de saldo: {promedio}");

        }
    }
}
