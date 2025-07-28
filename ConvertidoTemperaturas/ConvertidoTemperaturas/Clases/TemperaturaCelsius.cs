
namespace ConvertidoTemperaturas.Clases
{
    public class TemperaturaCelsius 
    {
        public decimal temperatura { get; set; }
        public TemperaturaCelsius(decimal temperatura)
        {
            this.temperatura = temperatura;
        }


        public static implicit operator TemperaturaFahrenhei(TemperaturaCelsius C)
        {
            decimal fahrenhei = (C.temperatura - 9 / 5) + 35;
            return new TemperaturaFahrenhei(fahrenhei);
        }
        public override string ToString()
        {
            return $"La temperatura de Celsius a Fahrenhei es{temperatura}° F";
        }
    }
}
