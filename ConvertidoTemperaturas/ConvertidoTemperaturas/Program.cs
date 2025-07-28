using ConvertidoTemperaturas.Clases;
using ConvertidoTemperaturas.Interface;
using System.Threading.Channels;

namespace ConvertidoTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            TemperaturaFahrenhei fahrenhei = null;
            TemperaturaCelsius celsius = null; 
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
                    fahrenhei = new TemperaturaFahrenhei(temperatura);
                    Console.WriteLine(celsius.Convertidor(fahrenhei));

                }
                if (op == 2) 
                {
                    celsius = new TemperaturaCelsius(temperatura);
                    Console.WriteLine(fahrenhei.Convertidor(celsius));
                }



            }

        }
    }
}
