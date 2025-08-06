using Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys;

namespace Sistema_de_Nomina_por_Categoria_de_Empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoPorHora empleado = new EmpleadoPorHora(1,"Juan","Gerente",45,15000);
            empleado.CalcularSalario();
            
        }
    }
}
