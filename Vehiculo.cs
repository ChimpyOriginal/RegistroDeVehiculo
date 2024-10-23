using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVehiculo
{
    public class Vehiculo
    {
        private static int contadorID = 0;
        public int ID { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        public Vehiculo(string marca, string modelo, int año)
        {
            this.ID = ++contadorID;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
        }
        
    }
}
