using ConvertidoTemperaturas.Interface;

namespace ConvertidoTemperaturas.Clases
{
    public class TemperaturaFahrenhei : ITemperatura<TemperaturaCelsius>
    {
        public decimal _temperatura;

        public TemperaturaFahrenhei(decimal temperatura)
        {
            _temperatura = temperatura;
        }

        public string Convertidor(TemperaturaCelsius C)
        {
            return $"La temperatura de Fahrenhei a Celsius es {(C._temperatura - 32) * 5 / 9}° C";
        }
    }
}
