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
    public partial class FrmAereo : Form
    {
        private ControladorVehiculos controlador;
        private FrmPrincipal menuPrincipal;
        public FrmAereo(ControladorVehiculos controlador, FrmPrincipal menuPrincipal)
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
            int numeroMotores = (int)numericMotores.Value;
            string tipoAereo = cmbTipoAereo.SelectedItem.ToString();

            VehiculoAereo nuevoVehiculo = new VehiculoAereo(marca, modelo, año, numeroMotores, tipoAereo);
            controlador.AgregarVehiculoAereo(nuevoVehiculo);

            ActualizarLista();

            MessageBox.Show("Vehículo aéreo agregado.");
        }

        private void ActualizarLista()
        {
            dgvVehiculosAereos.Rows.Clear();

            List<VehiculoAereo> listaAereos = controlador.ObtenerListaAereos();
            foreach (VehiculoAereo vehiculo in listaAereos)
            {
                dgvVehiculosAereos.Rows.Add( vehiculo.ID, vehiculo.TipoAereo, vehiculo.Marca, vehiculo.Modelo, vehiculo.Año, vehiculo.NumeroMotores);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculosAereos.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosAereos.SelectedRows[0].Index;

                controlador.EliminarVehiculoAereo(indiceSeleccionado);

                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.");
            }
        }
        private void dgvVehiculosAereos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehiculosAereos.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosAereos.SelectedRows[0].Index;

                VehiculoAereo vehiculoSeleccionado = controlador.ObtenerListaAereos()[indiceSeleccionado];

                txtMarca.Text = vehiculoSeleccionado.Marca;
                txtModelo.Text = vehiculoSeleccionado.Modelo;
                numericAño.Value = vehiculoSeleccionado.Año;
                numericMotores.Value = vehiculoSeleccionado.NumeroMotores;
                cmbTipoAereo.SelectedItem = vehiculoSeleccionado.TipoAereo;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculosAereos.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosAereos.SelectedRows[0].Index;

                VehiculoAereo vehiculoSeleccionado = controlador.ObtenerListaAereos()[indiceSeleccionado];

                vehiculoSeleccionado.Marca = txtMarca.Text;
                vehiculoSeleccionado.Modelo = txtModelo.Text;
                vehiculoSeleccionado.Año = (int)numericAño.Value;
                vehiculoSeleccionado.NumeroMotores = (int)numericMotores.Value;
                vehiculoSeleccionado.TipoAereo = cmbTipoAereo.SelectedItem.ToString();

                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para actualizar.");
            }
        }

        private void FrmAereo_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.MostrarMenu(); 
        }
    }
}
