namespace Presentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManejoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPaquetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActualizarPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManejoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestamosxCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestamosxEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSessionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar session";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManejoUsuarios,
            this.agregarPaquetesToolStripMenuItem,
            this.tsmManejoClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenimientoToolStripMenuItem.Text = "Administrador";
            // 
            // tsmManejoUsuarios
            // 
            this.tsmManejoUsuarios.Name = "tsmManejoUsuarios";
            this.tsmManejoUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmManejoUsuarios.Text = "Usuarios";
            this.tsmManejoUsuarios.Click += new System.EventHandler(this.tsmManejoUsuarios_Click);
            // 
            // agregarPaquetesToolStripMenuItem
            // 
            this.agregarPaquetesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarPrestamo,
            this.tsmActualizarPrestamo});
            this.agregarPaquetesToolStripMenuItem.Name = "agregarPaquetesToolStripMenuItem";
            this.agregarPaquetesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarPaquetesToolStripMenuItem.Text = "Prestamos";
            // 
            // tsmAgregarPrestamo
            // 
            this.tsmAgregarPrestamo.Name = "tsmAgregarPrestamo";
            this.tsmAgregarPrestamo.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarPrestamo.Text = "Agregar";
            this.tsmAgregarPrestamo.Click += new System.EventHandler(this.tsmAgregarPrestamo_Click);
            // 
            // tsmActualizarPrestamo
            // 
            this.tsmActualizarPrestamo.Name = "tsmActualizarPrestamo";
            this.tsmActualizarPrestamo.Size = new System.Drawing.Size(180, 22);
            this.tsmActualizarPrestamo.Text = "Actualizar";
            this.tsmActualizarPrestamo.Click += new System.EventHandler(this.tsmActualizarPrestamo_Click);
            // 
            // tsmManejoClientes
            // 
            this.tsmManejoClientes.Name = "tsmManejoClientes";
            this.tsmManejoClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmManejoClientes.Text = "Clientes";
            this.tsmManejoClientes.Click += new System.EventHandler(this.tsmManejoClientes_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPrestamosxCliente,
            this.tsmPrestamosxEstado});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // tsmPrestamosxCliente
            // 
            this.tsmPrestamosxCliente.Name = "tsmPrestamosxCliente";
            this.tsmPrestamosxCliente.Size = new System.Drawing.Size(188, 22);
            this.tsmPrestamosxCliente.Text = "Prestamos por cliente";
            this.tsmPrestamosxCliente.Click += new System.EventHandler(this.tsmPrestamosxCliente_Click);
            // 
            // tsmPrestamosxEstado
            // 
            this.tsmPrestamosxEstado.Name = "tsmPrestamosxEstado";
            this.tsmPrestamosxEstado.Size = new System.Drawing.Size(188, 22);
            this.tsmPrestamosxEstado.Text = "Prestamos por estado";
            this.tsmPrestamosxEstado.Click += new System.EventHandler(this.tsmPrestamosxEstado_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslNombreUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // tsslNombreUsuario
            // 
            this.tsslNombreUsuario.Name = "tsslNombreUsuario";
            this.tsslNombreUsuario.Size = new System.Drawing.Size(54, 17);
            this.tsslNombreUsuario.Text = "(usuario)";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmManejoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem agregarPaquetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarPrestamo;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizarPrestamo;
        private System.Windows.Forms.ToolStripMenuItem tsmManejoClientes;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestamosxCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestamosxEstado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslNombreUsuario;
    }
}

