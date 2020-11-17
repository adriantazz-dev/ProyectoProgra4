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
    public partial class frmAgregarPrestamos : Form
    {
        public frmAgregarPrestamos()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCedula.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cedula no ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtMonto.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Monto no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtTasa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tasa de interes no ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPlazo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Plazo del prestamo no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbFrecuencia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Frecuencia de pago no seleccionada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtFechaPago.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Fecha de pago no ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Prestamos objprestamo = new Prestamos();
                objprestamo.Cedula = Convert.ToInt32(txtCedula.Text.Trim());
                objprestamo.Monto = Convert.ToDecimal(txtMonto.Text.Trim());
                objprestamo.TasaInteres = Convert.ToDecimal(txtTasa.Text.Trim());
                objprestamo.Plazo = txtPlazo.Text;
                objprestamo.FrecuenciaPago = cmbFrecuencia.Text;
                objprestamo.FechaPago = txtFechaPago.Text;
                GestorConexiones.GestorConexionServicios.AgregarPrestamo(objprestamo);
                MessageBox.Show("Prestamo ha sido agregado ", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
