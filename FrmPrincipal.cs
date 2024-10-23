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
    public partial class FrmPrincipal : Form
    {
        private ControladorVehiculos controlador;
        private FrmTerrestre frmTerrestre;
        private FrmMarino frmMarino;
        private FrmAereo frmAereo;

        public FrmPrincipal()
        {
            InitializeComponent();
            controlador = new ControladorVehiculos();

            frmTerrestre = new FrmTerrestre(controlador,this);
            frmMarino = new FrmMarino(controlador,this);
            frmAereo = new FrmAereo(controlador,this);
        }

        private void btnTerrestres_Click(object sender, EventArgs e)
        {
            frmTerrestre.Show();
            this.Hide(); 
        }

        private void btnMarinos_Click(object sender, EventArgs e)
        {
            frmMarino.Show();
            this.Hide();
        }

        private void btnAereos_Click(object sender, EventArgs e)
        {
            frmAereo.Show(); 
            this.Hide();
        }

        public void MostrarMenu()
        {
            this.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
        }
    }
}
