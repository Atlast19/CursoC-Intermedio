

namespace Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys.BaseClass
{
    public abstract class EmpleadoBase
    {
        protected int ID { get; set; }
        protected string Nombre { get; set; }
        protected string Departamento { get; set; }


        protected EmpleadoBase(int ID, string Nombre, string Departamento)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Departamento = Departamento;
        }
        public abstract void CalcularSalario();
    }
}
