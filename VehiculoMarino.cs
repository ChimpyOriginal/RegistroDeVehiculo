using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVehiculo
{
    public class VehiculoMarino : Vehiculo
    {
        public string Uso { get; set; }
        public string TipoMarino { get; set; }
        public VehiculoMarino(string marca, string modelo, int año, string uso,string tipoMarino)
            : base(marca, modelo, año)
        {
            this.Uso = uso;
            this.TipoMarino = tipoMarino;
        }

    }
}
