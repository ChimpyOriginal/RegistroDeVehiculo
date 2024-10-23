using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVehiculo
{
    public class VehiculoAereo : Vehiculo
    {
        public int NumeroMotores { get; set; }
        public string TipoAereo { get; set; }

        public VehiculoAereo(string marca, string modelo, int año, int numeroMotores, string tipoAereo)
            : base(marca, modelo, año)
        {
            this.NumeroMotores = numeroMotores;
            this.TipoAereo = tipoAereo;
        }

    }
}
