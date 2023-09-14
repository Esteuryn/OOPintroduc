

using System;

namespace Homework1.Class
{
    public abstract class MiembrosComunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo  { get; set ;}
        public string Telefono { get; set; }


        public abstract void Guardar();
    
        public virtual void Obtener()
        { Console.WriteLine("Obteniendo"); }
    

    }

}

