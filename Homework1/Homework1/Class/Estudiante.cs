

using System;

namespace Homework1.Class
{
    public class Estudiante : MiembrosComunidad
    {
        public string Curso { get; set; }
        public string Matricula { get; set; }
        public string Grado { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando el docente");
        }

    }
}
