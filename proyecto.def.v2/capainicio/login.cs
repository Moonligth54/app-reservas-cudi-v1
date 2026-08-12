using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using capanegocio;
using capaentidad;

namespace capainicio
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // 1. Obtener lista mediante CapaNegocio
            List<usuarios> listaUsuarios = new CN_Usuario().Listar();

            // 2. Buscar coincidencias con la tabla usuarios (usuario y contrasena)
            usuarios ousuario = listaUsuarios.FirstOrDefault(u =>
                u.usuario == txtusuario.Text.Trim() &&
                u.contrasena == textclave.Text.Trim()
            );

            if (ousuario != null)
            {
                // 3. Validar si el usuario está activo (bool activo)
                if (!ousuario.activo)
                {
                    MessageBox.Show("El usuario se encuentra inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. Iniciar sesión pasando el objeto del usuario autenticado
                inicio form = new inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            textclave.Text = "";
            this.Show();
        }
    }
}