using System;
using System.Drawing;
using System.Windows.Forms;
using capaentidad;

namespace capainicio
{
    public partial class inicio : Form
    {
        private usuarios usuarioActual;

        public inicio()
        {
            InitializeComponent();
        }

        public inicio(usuarios ousuario)
        {
            InitializeComponent();
            this.usuarioActual = ousuario;

            if (this.usuarioActual != null)
            {
                lblNombreCompleto.Text = $"{this.usuarioActual.nombre} {this.usuarioActual.apellido}";
                lblDni.Text = $"Usuario: {this.usuarioActual.usuario}";
                lblCorreo.Text = $"Rol: {this.usuarioActual.nombre_rol}";
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            pnlPerfil.Visible = !pnlPerfil.Visible;

            if (pnlPerfil.Visible)
            {
                pnlPerfil.BringToFront();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar Sesión",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private Form formularioActivo = null;

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            this.contenedor.Controls.Add(formularioHijo);
            this.contenedor.Tag = formularioHijo;

            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        //private void menuusuario_Click(object sender, EventArgs e)
        //{
        //    AbrirFormularioHijo(new frmUsuarios());
        //}

        private void menumantenedor_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmRecursos());
        }

        private void menuprestamo_Click(object sender, EventArgs e)
        {
            // Corregido: Ahora pasa el usuario que inició sesión
            AbrirFormularioHijo(new frmPrestamos(usuarioActual));
        }

        private void menumaquinas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMaquinas());
        }

        private void menulibros_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmLibros());
        }

        private void menuhistorial_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmhistorial(usuarioActual));
        }
    }
}