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
    public partial class frmManejoClientes : Form
    {
        public frmManejoClientes()
        {
            InitializeComponent();
            CargarTabla();
        }
        public void CargarTabla()
        {
            dgvListadoClientes.DataSource = GestorConexiones.GestorConexionServicios.ConsultarClientes();
        }
        private void Limpiar()
        {
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            cmbEstado.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            txtTelefono.Text = string.Empty;
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones
                if (txtCedula.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cedula de cliente no ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtNombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Nombre del cliente no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtApellidos.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Apellidos de cliente no ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbEstadoCivil.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Estado civil no especificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbEstado.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Estado no especificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtTelefono.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Telefono de cliente no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Clientes objcliente = new Clientes();
                objcliente.Cedula = Convert.ToInt32(txtCedula.Text);
                objcliente.Nombre = txtNombre.Text;
                objcliente.Apellidos = txtApellidos.Text;
                objcliente.EstadoCivil = Convert.ToChar(cmbEstadoCivil.Text);
                objcliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                if (cmbEstado.Text == "Activo") { objcliente.EstadoCliente = true; } else { objcliente.EstadoCliente = false; };
                GestorConexiones.GestorConexionServicios.AgregarCliente(objcliente);
                MessageBox.Show("Cliente agregado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones
                if (txtCedula.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cedula de cliente no ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtNombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Nombre del cliente no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtApellidos.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Apellidos de cliente no ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbEstadoCivil.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Estado civil no especificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbEstado.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Estado no especificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtTelefono.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Telefono de cliente no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Clientes objcliente = new Clientes();
                objcliente.Cedula = Convert.ToInt32(txtCedula.Text);
                objcliente.Nombre = txtNombre.Text;
                objcliente.Apellidos = txtApellidos.Text;
                objcliente.EstadoCivil = Convert.ToChar(cmbEstadoCivil.Text);
                objcliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                if (cmbEstado.Text == "Activo") { objcliente.EstadoCliente = true; } else { objcliente.EstadoCliente = false; };
                GestorConexiones.GestorConexionServicios.ModificarCliente(objcliente);
                MessageBox.Show("Cliente modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones
                if (txtCedula.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cedula de cliente no ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Clientes objcliente = new Clientes();
                objcliente.Cedula = Convert.ToInt32(txtCedula.Text);
                GestorConexiones.GestorConexionServicios.EliminarCliente(objcliente);
                MessageBox.Show("Cliente eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
