using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class frmActualizarPrestamo : Form
    {
        public frmActualizarPrestamo()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPrestamo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Id no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbEstado.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Estado no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Prestamos objprestamo = new Prestamos();
                objprestamo.IdPrestamo = Convert.ToInt32(txtIdPrestamo.Text);
                objprestamo.Estado = cmbEstado.Text;
                GestorConexiones.GestorConexionServicios.ActualizarPrestamo(objprestamo);
                MessageBox.Show("Estado de prestamo actualizado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
