

using Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys.BaseClass;

namespace Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys
{
    public class EmpleadoPorComicion : EmpleadoBase
    {
        public double ComicionPorVentas { get; set; }
        public double SalarioPorComicion { get; set; }
        public EmpleadoPorComicion(int ID, string Nombre, string Departamento, double ComicionPorventas, double SalarioPorComicion) : base(ID, Nombre, Departamento)
        {
            this.ComicionPorVentas = ComicionPorventas;
            this.SalarioPorComicion = SalarioPorComicion;
        }


        public override void CalcularSalario()
        {
            Console.WriteLine($"ID: {ID} || Nombre: {Nombre} || Departemento: {Departamento} || " +
                $"Comicion por ventas: {ComicionPorVentas} || Salario por Comicion {SalarioPorComicion + (0.5 * ComicionPorVentas) } ");
        }
    }
}
