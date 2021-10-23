using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Automotriz
{
    class Repuesto
    {
        string tipoRepuesto;
        int codigo;
        long valor;
        int cantidadRepuesto;

        public Repuesto(string tipoRepuesto, int codigo, long valor, int cantidadRepuesto)
        {
            this.tipoRepuesto = tipoRepuesto ?? throw new ArgumentNullException(nameof(tipoRepuesto));
            this.codigo = codigo;
            this.valor = valor;
            this.cantidadRepuesto = cantidadRepuesto;
        }

        public string TipoRepuesto { get => tipoRepuesto; set => tipoRepuesto = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public long Valor { get => valor; set => valor = value; }
        public int CantidadRepuesto
        {
            get => cantidadRepuesto; set => cantidadRepuesto = value;
        }
    }
}
