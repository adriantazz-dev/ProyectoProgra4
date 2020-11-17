using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMenuPrincipal : Form
    {
        #region Propiedades
        Usuarios usuariologeado = new Usuarios();
        #endregion
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        public void CargarUsuario(Usuarios P_Usuario)
        {
            usuariologeado = P_Usuario;
            tsslNombreUsuario.Text = usuariologeado.Nombre;

        }

        private void tsmManejoUsuarios_Click(object sender, EventArgs e)
        {
            frmManejoUsuarios frm = new frmManejoUsuarios();
            frm.Show();
        }

        private void tsmPrestamosxCliente_Click(object sender, EventArgs e)
        {
            frmPrestamosPorCliente frm = new frmPrestamosPorCliente();
            frm.Show();
        }

        private void tsmPrestamosxEstado_Click(object sender, EventArgs e)
        {
            frmPrestamosPorEstado frm = new frmPrestamosPorEstado();
            frm.Show();
        }

        private void tsmAgregarPrestamo_Click(object sender, EventArgs e)
        {
            frmAgregarPrestamos frm = new frmAgregarPrestamos();
            frm.Show();
        }

        private void tsmManejoClientes_Click(object sender, EventArgs e)
        {
            frmManejoClientes frm = new frmManejoClientes();
            frm.Show();
        }

        private void tsmActualizarPrestamo_Click(object sender, EventArgs e)
        {
            frmActualizarPrestamo frm = new frmActualizarPrestamo();
            frm.Show();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
