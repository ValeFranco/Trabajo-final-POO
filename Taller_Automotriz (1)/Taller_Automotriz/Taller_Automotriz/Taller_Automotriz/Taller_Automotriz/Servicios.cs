using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
    class Servicio
    {
        Vehiculo vehiculo = new Vehiculo();
        Almacen almacen = new Almacen();

        private int codigo;
        private string nombre;
        private int valorhora;


        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int ValorHora { get => valorhora; set => valorhora = value; }
        public Almacen Almacenn { get => almacen; set => almacen = value; }
        public Vehiculo Vehiculoo { get => vehiculo; set => vehiculo = value; }

        public Servicio()
        {

        }

        public Servicio(int codigo, string nombre, int valorhora, Almacen almacen, Vehiculo vehiculo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.valorhora = valorhora;
            this.vehiculo = vehiculo;
            this.almacen = almacen;

        }


        //public void CambioAceite()
        //{

        //}
        //public void CambioFrenos()
        //{

        //}
        //public void CambioLlantas()
        //{

        //}
        //public void MantenimientoCajas()
        //{

        //}
        //public void Lavado()
        //{

        //}
        //public void EntregaEnCasa()
        //{

        //}

    }
}
