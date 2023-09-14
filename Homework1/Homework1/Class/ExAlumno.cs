
using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework1.Class
{
    public class ExAlumno : MiembrosComunidad 
    {
        public string ExCurso { get; set; }
        public string Matricula { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando el docente"); 
        }

        public override void Obtener()
        {
            Console.WriteLine("Obtener docente"); 
        }
    }
}
