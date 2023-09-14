

using System;

namespace Homework1.Class
{
    public class Administrativo : Empleado 
    {
        public int  Cedula { get; set; }
        public int Sueldo { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando el docente");
        }

    }
}
