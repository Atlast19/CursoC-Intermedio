using Sistema_de_Nomina_por_Categoria_de_Empleado.Entitys;

namespace Sistema_de_Nomina_por_Categoria_de_Empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ID = new Random();
            EmpleadoAsalariados Asalarioados = null;
            EmpleadoAsalarioadoPorComicion AsalarioadosPorComicion = null;
            EmpleadoPorComicion EmpleadoPorComicion = null;
            EmpleadoPorHora empleadoPorHora = null;
            //Menu par el sistema de gention de nomina por cartegoria de empleados
            bool salir = false;
            Console.WriteLine("Sistema de Gention de Nomina por Cartegoria de Empleados");
            while (!salir) {
                Console.WriteLine("Categoria de Empleados");
                Console.WriteLine("[1] Empleado Asalarioado");
                Console.WriteLine("[2] Empleado Asalariado por Comicion");
                Console.WriteLine("[3] Empleado por Comicion");
                Console.WriteLine("[4] Empleado por Hora");
                Console.WriteLine("[5] salir del sistema");
                Console.WriteLine("");
                Console.Write("Ingres su categoria de usuario: ");
                int categoria = int.Parse(Console.ReadLine());
                Console.WriteLine("");


                if (categoria == 1)
                {
                    Console.WriteLine("Ingrese los siguientes datos del empleado asalarioado");
                    Console.Write("Nombre del Empleado: ");
                    string Nombre = Console.ReadLine();
                    Console.Write("Departamento del Empleado: ");
                    string Departamento = Console.ReadLine();
                    Console.Write("Salario del Empleado: ");
                    double Salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    Asalarioados = new EmpleadoAsalariados(ID.Next(1, 999), Nombre, Departamento, Salario);
                    Asalarioados.CalcularSalario();
                    Console.WriteLine("");

                }
                else if (categoria == 2)
                {
                    Console.WriteLine("Ingrese los siguientes datos del empleado asalarioado por comicion");
                    Console.Write("Nombre del Empleado: ");
                    string Nombre = Console.ReadLine();
                    Console.Write("Departamento del Empleado: ");
                    string Departamento = Console.ReadLine();
                    Console.Write("Salario del Empleado: ");
                    double Salario = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la Comicion del Empleado: ");
                    double comicion = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    AsalarioadosPorComicion = new EmpleadoAsalarioadoPorComicion(ID.Next(1, 999), Nombre, Departamento, Salario, comicion);
                    AsalarioadosPorComicion.CalcularSalario();
                    Console.WriteLine("");
                }
                else if (categoria == 3) 
                {
                    Console.WriteLine("Ingrese los siguientes datos del empleado por comicion");
                    Console.Write("Nombre del Empleado: ");
                    string Nombre = Console.ReadLine();
                    Console.Write("Departamento del Empleado: ");
                    string Departamento = Console.ReadLine();
                    Console.Write("Salario del Empleado: ");
                    double Salario = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la Comicion del Empleado: ");
                    double comicion = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    EmpleadoPorComicion = new EmpleadoPorComicion(ID.Next(1, 999), Nombre, Departamento, Salario, comicion);
                    EmpleadoPorComicion.CalcularSalario();
                    Console.WriteLine("");
                } 
                else if (categoria == 4) 
                {
                    Console.WriteLine("Ingrese los siguientes datos del empleado por Hora");
                    Console.Write("Nombre del Empleado: ");
                    string Nombre = Console.ReadLine();
                    Console.Write("Departamento del Empleado: ");
                    string Departamento = Console.ReadLine();
                    Console.Write("Salario del Empleado: ");
                    double Salario = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese las Horas trabaajadas por el empleado: ");
                    int HorasTrabajadas = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    empleadoPorHora = new EmpleadoPorHora(ID.Next(1, 999), Nombre, Departamento, HorasTrabajadas, Salario);
                    empleadoPorHora.CalcularSalario();
                    Console.WriteLine("");
                }

                else if (categoria == 5)
                {
                    salir = true;
                }
                    




            }
            
        }
    }
}
