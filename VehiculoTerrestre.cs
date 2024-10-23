using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVehiculo
{
    public class VehiculoTerrestre : Vehiculo
    {
        public int NumeroCilindros{ get; set; }
        public string TipoTerrestre { get; set; }
        public VehiculoTerrestre(string marca, string modelo, int año, int numeroCilindros, string tipoTerrestre)
            : base(marca, modelo, año)
        {
            this.NumeroCilindros = numeroCilindros;
            this.TipoTerrestre = tipoTerrestre;
        }
    }
}
