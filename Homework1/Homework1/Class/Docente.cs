
using System;

namespace Homework1.Class
{
    public class Docente : Empleado
    {
        public string Estado { get; set; }
        public int Numero { get; set; }
        public int Cedula { get; set; } 
        public int Sueldo { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando el docente");
        }
    }
}
