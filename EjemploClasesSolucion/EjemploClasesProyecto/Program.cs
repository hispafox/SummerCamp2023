using Entidades;

namespace EjemploClasesProyecto
{
    // Calcular salario de empleados

    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear y asignar propiedades mediante la instancia
            var jose = new Empleado();
            jose.Nombre = "Jose";
            jose.FechaAlta = new DateTime(2021, 01, 10);
            jose.Salario = 20000;
            jose.Alta = true;
            jose.FijarNivel(Empleado.Nivel.excelente);


            // Crear y asignar valores a propiedades directamente
            var maria = new Empleado()
            {
                Nombre = "Maria",
                FechaAlta = new DateTime(2022, 03, 01),
                Salario = 20000,
                Alta = true
            };
            maria.FijarNivel(Empleado.Nivel.excelente);

            // Crear instancia y pasarle parametros al constructor
            var juan = new Empleado("Juan",
                                    20000,
                                    new DateTime(2023,01,15),
                                    true);
            juan.FijarNivel(Empleado.Nivel.excelente);

            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            numeros.Add(9);


            var lista = new List<Empleado>();
            lista.Add(maria);
            lista.Add(jose);
            lista.Add(juan);

            foreach (var empleado in lista) {

                empleado.CalcularAumentoSalario();
            
            }



        }
    }
}