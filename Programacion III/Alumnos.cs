using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_III
{
    public class Alumnos
    {
        public int legajo;
        public string nombre { get; set; }
        public string apellido { get; set;  }

        public Alumnos(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public override string ToString()
        {
            return this.legajo.ToString();
        }
    }
}
