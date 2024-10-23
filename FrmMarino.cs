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
    public partial class FrmMarino : Form
    {
        private ControladorVehiculos controlador; 
        private FrmPrincipal menuPrincipal;

        public FrmMarino(ControladorVehiculos controlador, FrmPrincipal menuPrincipal)
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
            string uso = cmbUso.SelectedItem.ToString();
            string tipoMarino = cmbTipoMarinos.SelectedItem.ToString();

            VehiculoMarino nuevoVehiculo = new VehiculoMarino(marca, modelo, año, uso, tipoMarino);

            controlador.AgregarVehiculoMarino(nuevoVehiculo);

            ActualizarLista();

            MessageBox.Show("Vehículo marino agregado.");
        }

        private void ActualizarLista()
        {
            dgvVehiculosMarinos.Rows.Clear();

            List<VehiculoMarino> listaMarinos = controlador.ObtenerListaMarinos();

            foreach (VehiculoMarino vehiculo in listaMarinos)
            {
                dgvVehiculosMarinos.Rows.Add(vehiculo.ID, vehiculo.TipoMarino, vehiculo.Marca, vehiculo.Modelo, vehiculo.Año, vehiculo.Uso);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculosMarinos.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosMarinos.SelectedRows[0].Index;

                controlador.EliminarVehiculoMarino(indiceSeleccionado);

                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.");
            }
        }
        private void dgvVehiculosMarinos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehiculosMarinos.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosMarinos.SelectedRows[0].Index;

                VehiculoMarino vehiculoSeleccionado = controlador.ObtenerListaMarinos()[indiceSeleccionado];

                txtMarca.Text = vehiculoSeleccionado.Marca;
                txtModelo.Text = vehiculoSeleccionado.Modelo;
                numericAño.Value = vehiculoSeleccionado.Año;
                cmbUso.SelectedItem = vehiculoSeleccionado.Uso;
                cmbTipoMarinos.SelectedItem = vehiculoSeleccionado.TipoMarino;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculosMarinos.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvVehiculosMarinos.SelectedRows[0].Index;

                VehiculoMarino vehiculoSeleccionado = controlador.ObtenerListaMarinos()[indiceSeleccionado];

                vehiculoSeleccionado.Marca = txtMarca.Text;
                vehiculoSeleccionado.Modelo = txtModelo.Text;
                vehiculoSeleccionado.Año = (int)numericAño.Value;
                vehiculoSeleccionado.Uso = cmbUso.SelectedItem.ToString();
                vehiculoSeleccionado.TipoMarino = cmbTipoMarinos.SelectedItem.ToString();

                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para actualizar.");
            }
        }
        private void FrmMarino_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.MostrarMenu();
        }

    }
}
