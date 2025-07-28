

namespace ConvertirDistancias.clases
{
    public class Millas
    {
        public double millas { get; set; }

        public Millas(double millas)
        {
            this.millas = millas;
        }

        public string MillaKilometros() 
        {
            return $"La convercion de millas a kilometros es de {(millas * 1.60934)} Kilometros";
        }
    }
}
