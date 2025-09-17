namespace _22.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales
            //Vectores

            int[] numeros = new int[5];

            string[] nombres = new string[4];

            //Almacenemos datos
            numeros[0] = 12;
            numeros[1] = 1;
            numeros[2] = 112;
            numeros[3] = 45;
            numeros[4] = 16;
            //numeros[5] = 0; no se puede almacenar el dato porque la posición con indoce 5 no existe

            //recuperar datos
            Console.WriteLine($"El valor almacenado en la posición 4, con índice 3 es {numeros[3]}");

            //Recorrer para almacenar
            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posición {i+1}, con índice {i}");
                numeros[i] = int.Parse( Console.ReadLine() );
                 
            }

            //Otras formas de declarar e inicializar vectores
            char[] caracteres = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            float[] numeros2 = { 0.3f, 1.5f, 2.5f, 4.5f, 0.0f};

            //Recorrer para recuperar datos almacenados

            for(int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"P: {i + 1} -I: {i}: {caracteres[i]}");
            }
            
            for(int i = 0;i < 5; i++)
            {
                 Console.WriteLine($"Ingrese un numbre para la posicion {i+1}, con indice {i}");
                nombres[i] = Console.ReadLine();

                Console.WriteLine($"P: {i + 1} -I: {i}: {nombres[i]}");

            } 
           
        }
    }
}
