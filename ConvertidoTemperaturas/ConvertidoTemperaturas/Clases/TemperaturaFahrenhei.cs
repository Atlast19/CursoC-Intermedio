

namespace ConvertidoTemperaturas.Clases
{
    public class TemperaturaFahrenhei 
    {
        public decimal temperatura { get; set; }

        public TemperaturaFahrenhei(decimal temperatura)
        {
            this.temperatura = temperatura;
        }

        public static implicit operator TemperaturaCelsius (TemperaturaFahrenhei C)
        {
            decimal celsius = (C.temperatura - 32) * 5 / 9;
            return new TemperaturaCelsius(celsius);
        }

        public override string ToString()
        {
            return $"La temperatura de Fahrenhei a Celsius es {temperatura}° C";

        }
    }
}
