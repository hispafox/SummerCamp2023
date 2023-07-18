namespace Entidades
{
    // https://learn.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    public class Empleado
    {

        public enum Nivel
        {
            normal,
            bueno,
            excelente

        }

           private Nivel _nivel;

        public void FijarNivel(Nivel nivel)
        {
            this._nivel = nivel;
        }


        public Empleado()
        {

        }

        public Empleado(string nombre,
                         double salario,
                         DateTime fechaAlta,
                         bool alta)
        {
            Nombre = nombre;
            Salario = salario;
            FechaAlta = fechaAlta;
            Alta = alta;
        }


        public string Nombre { get; set; }

        public double Salario { get; set; }

        public DateTime FechaAlta { get; set; } = DateTime.Now;

        public bool Alta { get; set; }

        public void CalcularAumentoSalario()
        {
            //throw new NotImplementedException();
        }
    }
}
