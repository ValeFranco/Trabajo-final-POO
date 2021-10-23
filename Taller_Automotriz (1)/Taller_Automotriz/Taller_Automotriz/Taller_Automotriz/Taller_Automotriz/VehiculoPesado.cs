using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
    class VehiculoPesado : Vehiculo
    {
        protected VehiculoPesado(string placa, string modelo, string dueño, string tipoCombustible, string tipoVehiculo) : base(placa, modelo, dueño, tipoCombustible, tipoVehiculo)
        {

        }
    }
}
