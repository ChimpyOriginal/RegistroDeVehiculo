using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeVehiculo
{
    public partial class FrmTerrestre : Form
    {
        private ControladorVehiculos controlador;
        private FrmPrincipal menuPrincipal;

        public FrmTerrestre(ControladorVehiculos controlador, FrmPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.menuPrincipal = menuPrincipal;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int año = (int)numericAño.Value;
            int numeroCilindros = (int)numericCilindros.Value;
            string tipoTerrestre = cmbTipoTerrestre.SelectedItem.ToString();

            VehiculoTerrestre nuevoVehiculo = new VehiculoTerrestre(marca, modelo, año, numeroCilindros, tipoTerrestre);
            controlador.AgregarVehiculoTerrestre(nuevoVehiculo);

            ActualizarLista();

            MessageBox.Show("Vehículo terrestre agregado.");
        }

        private void FrmTerrestre_Load(object sender, EventArgs e)
        {

        }
        private void ActualizarLista()
        {
            dgvVehiculosTerrestres.Rows.Clear();

            List<VehiculoTerrestre> listaTerrestres = controlador.ObtenerVehiculosTerrestres();

            foreach (VehiculoTerrestre vehiculo in listaTerrestres)
            {
                dgvVehiculosTerrestres.Rows.Add(vehiculo.ID, vehiculo.TipoTerrestre, vehiculo.Marca, vehiculo.Modelo, vehiculo.Año, vehiculo.NumeroCilindros);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculosTerrestres.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosTerrestres.SelectedRows[0].Index;

                VehiculoTerrestre vehiculoSeleccionado = controlador.ObtenerVehiculosTerrestres()[indiceSeleccionado];
                controlador.EliminarVehiculoTerrestre(vehiculoSeleccionado);

                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.");
            }
        }
        private void dgvVehiculosTerrestres_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehiculosTerrestres.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosTerrestres.SelectedRows[0].Index;

                VehiculoTerrestre vehiculoSeleccionado = controlador.ObtenerVehiculosTerrestres()[indiceSeleccionado];

                txtMarca.Text = vehiculoSeleccionado.Marca;
                txtModelo.Text = vehiculoSeleccionado.Modelo;
                numericAño.Value = vehiculoSeleccionado.Año;
                numericCilindros.Value = vehiculoSeleccionado.NumeroCilindros;
                cmbTipoTerrestre.SelectedItem = vehiculoSeleccionado.TipoTerrestre;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculosTerrestres.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosTerrestres.SelectedRows[0].Index;

                VehiculoTerrestre vehiculoSeleccionado = controlador.ObtenerVehiculosTerrestres()[indiceSeleccionado];

                vehiculoSeleccionado.Marca = txtMarca.Text;
                vehiculoSeleccionado.Modelo = txtModelo.Text;
                vehiculoSeleccionado.Año = (int)numericAño.Value;
                vehiculoSeleccionado.NumeroCilindros = (int)numericCilindros.Value;
                vehiculoSeleccionado.TipoTerrestre = cmbTipoTerrestre.SelectedItem.ToString();

                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para actualizar.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            menuPrincipal.MostrarMenu(); 
        }
    }
}
