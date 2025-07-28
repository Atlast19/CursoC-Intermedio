using ConvertirDistancias.clases;

namespace ConvertirDistancias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            Console.WriteLine("Convertidor de distancias");
            while (!salir) 
            {
                Console.WriteLine("[1] para convertir Millas en Kilometros");
                Console.WriteLine("[2] para convertir Kilometros en millas");
                Console.Write("Valor: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (op == 1) 
                {
                    Console.WriteLine("Ingrese la cantidad de Millas que quiere convertir a Kilometros");
                    Console.Write("valor: ");
                    double milla = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    Millas millas = new Millas(milla);
                    Console.WriteLine(millas.MillaKilometros());
                    Console.WriteLine("");

                }else if (op == 2)
                {
                    Console.WriteLine("Ingrese la cantidad de Kilometros que quiere convertir a Millas");
                    Console.Write("valor: ");
                    double kilometo = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    Kilometros kilometros = new Kilometros(kilometo);
                    Console.WriteLine(kilometros.KilometrosMillas());
                    Console.WriteLine("");
                }
            }
        }
    }
}
