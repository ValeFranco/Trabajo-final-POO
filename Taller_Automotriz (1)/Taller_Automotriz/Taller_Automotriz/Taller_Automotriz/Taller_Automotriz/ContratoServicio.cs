using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
    class ContratoServicio
    {
        List<Servicio> servicios = new List<Servicio>();
        private int cantidadHoraServicios;

        public int CantidadHoraServicios { get => cantidadHoraServicios; set => cantidadHoraServicios = value; }

        public ContratoServicio()
        {
            cantidadHoraServicios = 0;
        }

        public ContratoServicio(int cantidadHoraServicios)
        {
            this.cantidadHoraServicios = cantidadHoraServicios;
        }
    }
}
