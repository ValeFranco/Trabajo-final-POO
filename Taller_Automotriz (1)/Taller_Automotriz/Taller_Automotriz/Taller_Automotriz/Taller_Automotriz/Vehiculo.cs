using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
     class Vehiculo
    {
        private string placa;
        private string modelo;
        private string dueño;
        private string tipoCombustible;
        private string tipoVehiculo;

        public Vehiculo(string placa, string modelo, string dueño, string tipoCombustible, string tipoVehiculo)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Dueño = dueño;
            this.TipoCombustible = tipoCombustible;
            this.TipoVehiculo = tipoVehiculo;
        }

        public Vehiculo()
        {
            this.Placa = "123";
            this.Modelo = "Estandar";
            this.Dueño = "Fulano";
            this.TipoCombustible = "Gasolina";
            this.TipoVehiculo = "Vehiculo Liviano";
        }

        protected string Placa { get => placa; set => placa = value; }
        protected string Modelo { get => modelo; set => modelo = value; }
        protected string Dueño { get => dueño; set => dueño = value; }
        protected string TipoCombustible { get => tipoCombustible; set => tipoCombustible = value; }
        protected string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }

    }
}
