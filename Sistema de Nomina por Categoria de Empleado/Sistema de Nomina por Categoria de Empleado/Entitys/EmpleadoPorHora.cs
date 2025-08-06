

using Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys.BaseClass;

namespace Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys
{
    public class EmpleadoPorHora : EmpleadoBase
    {
        public int HorasTrabajadas { get; set; }
        public double SalarioPorHora { get; set; }

        public EmpleadoPorHora(int ID, string Nombre, string Departamento, int HorasTrabajadas, double SalarioPorHora ) : base(ID, Nombre, Departamento)
        {
            this.HorasTrabajadas = HorasTrabajadas;
            this.SalarioPorHora = SalarioPorHora;
        }


        public override void CalcularSalario()
        {
            int HorasNormales = 40;
            int horasExtras = HorasTrabajadas - 40;

            if (HorasTrabajadas >= 40)
            {
                Console.WriteLine($"ID: {ID} || Nombre: {Nombre} || Departemento: {Departamento} || Horas Trabajadas {HorasTrabajadas} || Salario Por Hora: {(SalarioPorHora * HorasNormales) + (horasExtras * SalarioPorHora * 0.05 )}");
            }
            else 
            {
                Console.WriteLine($"ID: {ID} || Nombre: {Nombre} || Departemento: {Departamento} || Horas Trabajadas {HorasTrabajadas} || Salario Por Hora: {(SalarioPorHora * HorasTrabajadas) }");
            }
        }
    }
}
