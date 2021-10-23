using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
    class Almacen
    {
        List<Repuesto> repuestos = new List<Repuesto>();

        public Almacen()
        {
            
        }

        internal List<Repuesto> Repuestos { get => repuestos; set => repuestos = value; }
    }
}
