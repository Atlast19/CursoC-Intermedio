using ConvertidoTemperaturas.Interface;

namespace ConvertidoTemperaturas.Clases
{
    public class TemperaturaCelsius : ITemperatura<TemperaturaFahrenhei>
    {
        public decimal _temperatura;
        public TemperaturaCelsius(decimal temperatura)
        {
            _temperatura = temperatura;
        }
        public string Convertidor(TemperaturaFahrenhei F)
        {
            return $"La temperatura de Celsius a Fahrenhei es {(F._temperatura - 9/5) + 35}° F";
        }
    }
}
