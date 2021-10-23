using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
    class JefePatio
    {
        List<Atencion> atenciones = new List<Atencion>();
        List<Servicio> servicios = new List<Servicio>();
        List<Repuesto> repuestos = new List<Repuesto>();
        Almacen almacen = new Almacen();

        public JefePatio()
        {

        }

        internal List<Atencion> Atenciones { get => atenciones; set => atenciones = value; }
        internal List<Servicio> Servicio { get => Servicio; set => Servicio = value; }
        internal Almacen Almacen { get => almacen; set => almacen = value; }
    }
}
