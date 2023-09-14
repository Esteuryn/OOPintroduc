

using System;

namespace Homework1.Class
{
    public class Maestro : Docente 
    {
        public string CantidadAlumnos { get; set; }
        public string Materia { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando el docente");
        }
    }
}
