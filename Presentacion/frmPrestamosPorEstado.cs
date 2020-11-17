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
    public partial class frmPrestamosPorEstado : Form
    {
        public frmPrestamosPorEstado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Prestamos objprestamo = new Prestamos();
            try
            {
                if (cmbEstado.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Estado del prestamo no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbEstado.Text.Trim() == "Activo")
                {
                    objprestamo.Estado = "Activo";
                }
                if (cmbEstado.Text.Trim() == "En atráso")
                {
                    objprestamo.Estado = "En atráso";
                }
                if (cmbEstado.Text.Trim() == "Finalizado")
                {
                    objprestamo.Estado = "Finalizado";
                }
                if (cmbEstado.Text.Trim() == "Cobro judicial")
                {
                    objprestamo.Estado = "Cobro judicial";
                }
                dgvListadoPrestamos.DataSource = GestorConexiones.GestorConexionServicios.ConsultarPrestamosPorEstado(objprestamo);
                dgvListadoPrestamos.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
