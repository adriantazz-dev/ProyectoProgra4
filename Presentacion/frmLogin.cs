using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Contador para limitar intentos a 3
        int contador = 0;

        #region Manejo de eventos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Id de usuario no ha sido ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtPass.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Contraseña no ha sido ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Usuarios objusuario = new Usuarios();
                objusuario.IdUsuario = txtUsuario.Text.ToString();
                objusuario.Contrasena = txtPass.Text.ToString();

                List<Usuarios> resultado = GestorConexiones.GestorConexionServicios.VerificarUsuario(objusuario);

                //Se se asigna el valor NombreUsuario a objusuario para dar la bienvenida
                foreach (Usuarios item in resultado)
                {
                    objusuario.IdUsuario = item.IdUsuario;
                    objusuario.Nombre = item.Nombre;
                }

                if (GestorConexiones.GestorConexionServicios.VerificarUsuario(objusuario).Count > 0)
                {

                    MessageBox.Show("Bienvenido " + objusuario.Nombre);
                    frmMenuPrincipal frm = new frmMenuPrincipal();
                    frm.CargarUsuario(objusuario);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    contador++;
                    if (contador > 2)
                    {
                        MessageBox.Show("Ha llegado al maximo de intentos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Informacion incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };


                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRecuperarPass(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Id de usuario no ha sido ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Usuarios objusuario = new Usuarios();
                objusuario.IdUsuario = txtUsuario.Text.ToString();
                List<Usuarios> resultado = GestorConexiones.GestorConexionServicios.VerificarEmailUsuario(objusuario);

                if (resultado.Count == 0)
                {
                    MessageBox.Show("Id de usuario no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    //Se se asigna el valor Email a objusuario para despues enviar el email
                    foreach (Usuarios item in resultado)
                    {
                        objusuario.Email = item.Email;
                        objusuario.Contrasena = item.Contrasena;
                    }
                    //Se usa una expresión lambda para poder usar un metodo con parametros en el new thread
                    Thread hilosecundario = new Thread(() => EnviarCorreo(objusuario));
                    hilosecundario.Start();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        private void EnviarCorreo(Usuarios P_Usuario)
        {
            try
            {
                Correo correo = new Correo();
                correo.Asunto = "Recuperación de contraseña";
                correo.Remitente = "adrian.progra3@gmail.com";
                correo.Destinatario = new List<string>();
                correo.Destinatario.Add(P_Usuario.Email);
                correo.MensajeCorreo = "Tu contraseña es: " + P_Usuario.Contrasena;
                GestorConexiones.GestorConexionServicios.EnviarCorreoElectronico(correo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
