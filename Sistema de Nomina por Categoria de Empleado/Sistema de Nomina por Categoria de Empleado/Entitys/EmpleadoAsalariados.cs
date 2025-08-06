

using Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys.BaseClass;

namespace Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys
{
    public class EmpleadoAsalariados : EmpleadoBase
    {
        public double SalarioFijo { get; set; }


        public EmpleadoAsalariados(int ID, string Nombre, string Departamento, double SalarioFijo) : base(ID,Nombre,Departamento)
        {
            this.SalarioFijo = SalarioFijo;
        }

        public override void CalcularSalario()
        {
            Console.WriteLine($"ID: {ID} || Nombre: {Nombre} || Departemento: {Departamento} || Salario fijo es de: {SalarioFijo}");
        }
    }
}
