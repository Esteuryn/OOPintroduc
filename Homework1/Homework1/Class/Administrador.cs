
namespace Homework1.Class
{
    public class Administrador : Docente 
    {
        public string Salario { get; set; }
        public string Celular { get; set; }
        public int gastos { get; set; }
        public int presupuesto { get; set; }

        public override void Guardar()
        {
            throw new System.NotImplementedException();
        }

    }
}
