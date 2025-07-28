

namespace ConvertirDistancias.clases
{
    public class Kilometros
    {
        public double kilometros { get; set; }

        public Kilometros(double kilometros)
        {
            this.kilometros = kilometros;
        }

        public string KilometrosMillas()
        {
            return $"La convercion de Kilometros a Millas es de {(kilometros / 1.60934)} Millas";
        }
    }
}
