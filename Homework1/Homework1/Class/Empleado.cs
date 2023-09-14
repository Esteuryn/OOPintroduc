

using System;

namespace Homework1.Class
{
    public class Empleado : MiembrosComunidad
    {
        public string ID { get; set; }
        public string Departamento { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando el docente");
        }

    }
}
