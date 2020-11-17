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
    public partial class frmPrestamosPorCliente : Form
    {
        public frmPrestamosPorCliente()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Prestamos objprestamo = new Prestamos();
            try
            {
                if (txtCedula.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cedula del cliente no ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                objprestamo.Cedula = Convert.ToInt32(txtCedula.Text);
                dgvListadoPrestamos.DataSource = GestorConexiones.GestorConexionServicios.ConsultarPrestamosPorCliente(objprestamo);
                dgvListadoPrestamos.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
