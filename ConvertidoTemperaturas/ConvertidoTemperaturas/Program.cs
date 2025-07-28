using ConvertidoTemperaturas.Clases;

namespace ConvertidoTemperaturas
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            Console.WriteLine("Sistema de convercion de temperatura");
            while (!salir)
            {
                Console.WriteLine("[1] Para convertir de Celsius a Fahrenhei");
                Console.WriteLine("[2] Para convertir de Fahrenhei a celsius");
                Console.Write("Valor: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("Ingrese el valor de la temperatura a convertir: ");
                decimal temperatura = decimal.Parse(Console.ReadLine());
                
                
                if (op == 1) 
                {

                    TemperaturaFahrenhei fahrenhei = new TemperaturaFahrenhei(temperatura);
                    TemperaturaCelsius celsius = fahrenhei;
                    Console.WriteLine(celsius);
                    Console.WriteLine("");

                }
                if (op == 2) 
                {
                    

                    TemperaturaCelsius celsius = new TemperaturaCelsius(temperatura);
                    TemperaturaFahrenhei fahrenhei = celsius;
                    Console.WriteLine(fahrenhei);
                    Console.WriteLine("");
                }



            }

        }
    }
}
