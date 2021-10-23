using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
    class Atencion
    {
        private DateTime fecha;
        private string tipoAtencion;
        List<ContratoServicio> contratoServicio = new List<ContratoServicio>();
        Vehiculo vehiculo = new Vehiculo();

        public Atencion(DateTime fecha, string tipoAtencion)
        {
            this.fecha = fecha;
            this.tipoAtencion = tipoAtencion;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Vehiculo Vehiculoo { get => vehiculo; set => vehiculo = value; }
        public string TipoAtencion { get => tipoAtencion; set => tipoAtencion = value; }

                          
        //public void Subtotal(List<ContratoServicio> contratoServicios)

        //{
        //}

        //public void TotalRecargos(List<ContratoServicio> contratoServicios)

        //{
        //}

        //public void TotalDescuentos(List<ContratoServicio> contratoServicios)

        //{
        //}
        //public void CostoTotal(List<ContratoServicio> contratoServicios)

        //{
        //}
    }
}
