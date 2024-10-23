using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVehiculo
{
    public class ControladorVehiculos
    {
        private List<VehiculoTerrestre> listaTerrestres = new List<VehiculoTerrestre>();
        private List<VehiculoMarino> listaMarinos = new List<VehiculoMarino>();
        private List<VehiculoAereo> listaAereos = new List<VehiculoAereo>();

        public List<VehiculoTerrestre> ObtenerVehiculosTerrestres()
        {
            return listaTerrestres;
        }

        public void AgregarVehiculoTerrestre(VehiculoTerrestre vehiculo)
        {
            listaTerrestres.Add(vehiculo);
        }

        public void EliminarVehiculoTerrestre(VehiculoTerrestre vehiculo)
        {
            listaTerrestres.Remove(vehiculo);
        }
        public void AgregarVehiculoMarino(VehiculoMarino vehiculo)
        {
            listaMarinos.Add(vehiculo);
        }

        public List<VehiculoMarino> ObtenerListaMarinos()
        {
            return listaMarinos;
        }

        public void EliminarVehiculoMarino(int indice)
        {
            listaMarinos.RemoveAt(indice);
        }
        public void AgregarVehiculoAereo(VehiculoAereo vehiculo)
        {
            listaAereos.Add(vehiculo);
        }

        public List<VehiculoAereo> ObtenerListaAereos()
        {
            return listaAereos;
        }

        public void EliminarVehiculoAereo(int indice)
        {
            listaAereos.RemoveAt(indice);
        }
    }
}
