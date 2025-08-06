using Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys.BaseClass;
 

namespace Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys
{
    internal class EmpleadoAsalarioadoPorComicion : EmpleadoBase
    {
        public double SalarioBase { get; set; }
        public  double Comicion { get; set; }
        public EmpleadoAsalarioadoPorComicion(int ID, string Nombre, string Departamento, double SalarioBase, double Comicion) : base(ID, Nombre, Departamento)
        {
            this.SalarioBase = SalarioBase;
            this.Comicion = Comicion;
        }

        public override void CalcularSalario()
        {
            Console.WriteLine($"ID: {ID} || Nombre: {Nombre} || Departemento: {Departamento} || Comicion por Ventas: {Comicion} || Salario Base: {(SalarioBase + Comicion) + 0.1 }");
        }
    }
}
