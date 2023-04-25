using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_III
{
    public class AlumnosCollection : KeyedCollection<int, Alumnos>
    {
        protected override int GetKeyForItem(Alumnos item)
        {
            return item.legajo;
        }
    }
}
