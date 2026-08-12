using System;
using System.Collections.Generic;
using System.Windows.Forms;
using capaentidad;
using capanegocio;

namespace capainicio
{
    public partial class frmPrestamos : Form
    {
        private usuarios usuarioLogueado;
        private personas alumnoSeleccionado = null;
        private CN_Persona objCN_Persona = new CN_Persona();
        private CN_Prestamo objCN_Prestamo = new CN_Prestamo();

        public frmPrestamos()
        {
            InitializeComponent();
        }

        public frmPrestamos(usuarios usuario)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            CargarRecursosDisponibles();
            MostrarUsuarioActivo();

            if (cboEstadoFisico.Items.Count == 0)
            {
                cboEstadoFisico.Items.Add("Bueno");
                cboEstadoFisico.Items.Add("Regular");
                cboEstadoFisico.Items.Add("Dañado");
                cboEstadoFisico.SelectedIndex = 0;
            }

            chkTipoRecurso_CheckedChanged(null, null);
        }

        private void MostrarUsuarioActivo()
        {
            if (usuarioLogueado != null)
            {
                lblRecepcionistaActivo.Text = $"Operador: {usuarioLogueado.nombre} {usuarioLogueado.apellido}";
            }
            else
            {
                lblRecepcionistaActivo.Text = "Operador: Sin Sesión (Modo Prueba)";
            }
        }

        private void CargarRecursosDisponibles()
        {
            List<recursos> listaComputadoras = objCN_Prestamo.ObtenerComputadorasDisponibles();
            cboComputadoras.DataSource = listaComputadoras;
            cboComputadoras.DisplayMember = "observaciones";
            cboComputadoras.ValueMember = "id_recurso";

            List<recursos> listaLibros = objCN_Prestamo.ObtenerLibrosDisponibles();
            cboLibros.DataSource = listaLibros;
            cboLibros.DisplayMember = "observaciones";
            cboLibros.ValueMember = "id_recurso";

            cboComputadoras.SelectedIndex = listaComputadoras.Count > 0 ? 0 : -1;
            cboLibros.SelectedIndex = listaLibros.Count > 0 ? 0 : -1;
        }

        private void chkTipoRecurso_CheckedChanged(object sender, EventArgs e)
        {
            cboComputadoras.Enabled = chkComputadora.Checked;
            cboLibros.Enabled = chkLibro.Checked;
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string mensaje;
            alumnoSeleccionado = objCN_Persona.BuscarPorDni(txtDniAlumno.Text.Trim(), out mensaje);

            if (alumnoSeleccionado != null)
            {
                lblNombreAlumno.Text = $"{alumnoSeleccionado.nombre} {alumnoSeleccionado.apellido}";
                CargarHistorialAlumno(alumnoSeleccionado.id_persona);
            }
            else
            {
                LimpiarDatosAlumno();
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un alumno válido antes de registrar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkComputadora.Checked && !chkLibro.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos un recurso (Computadora o Libro).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkComputadora.Checked && cboComputadoras.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una computadora disponible.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkLibro.Checked && cboLibros.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un libro disponible.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuarioLogueado != null)
            {
                string claveIngresada = txtClaveConfirmacion.Text.Trim();

                if (string.IsNullOrEmpty(claveIngresada))
                {
                    MessageBox.Show("Por seguridad, debe ingresar su contraseña para confirmar la operación.", "Confirmación Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveConfirmacion.Focus();
                    return;
                }

                if (claveIngresada != usuarioLogueado.contrasena)
                {
                    MessageBox.Show("La contraseña ingresada es incorrecta. Operación no autorizada.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtClaveConfirmacion.Clear();
                    txtClaveConfirmacion.Focus();
                    return;
                }
            }

            int idUsuarioLogueado = usuarioLogueado != null ? usuarioLogueado.id_usuario : 1;
            List<int> idsRecursos = new List<int>();

            if (chkComputadora.Checked)
            {
                idsRecursos.Add(Convert.ToInt32(cboComputadoras.SelectedValue));
            }

            if (chkLibro.Checked)
            {
                idsRecursos.Add(Convert.ToInt32(cboLibros.SelectedValue));
            }

            int registradosExitosos = 0;
            string errores = "";

            foreach (int idRecurso in idsRecursos)
            {
                prestamos nuevoPrestamo = new prestamos()
                {
                    id_persona = alumnoSeleccionado.id_persona,
                    id_recurso = idRecurso,
                    id_usuario = idUsuarioLogueado,
                    observaciones = txtObservaciones != null ? txtObservaciones.Text.Trim() : ""
                };

                string mensaje;
                if (objCN_Prestamo.RegistrarPrestamo(nuevoPrestamo, out mensaje))
                {
                    registradosExitosos++;
                }
                else
                {
                    errores += $"\n- {mensaje}";
                }
            }

            if (registradosExitosos > 0)
            {
                MessageBox.Show($"Préstamo(s) registrado(s) con éxito ({registradosExitosos}).{(string.IsNullOrEmpty(errores) ? "" : "\n\nDetalles:" + errores)}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClaveConfirmacion.Clear();
                CargarRecursosDisponibles();
                CargarHistorialAlumno(alumnoSeleccionado.id_persona);
            }
            else
            {
                MessageBox.Show($"No se pudo registrar el préstamo:{errores}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (dgvHistorialAlumno.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo de la tabla para registrar la devolución.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvHistorialAlumno.CurrentRow.Cells["fecha_devolucion"].Value != null &&
                !string.IsNullOrEmpty(dgvHistorialAlumno.CurrentRow.Cells["fecha_devolucion"].Value.ToString()) &&
                dgvHistorialAlumno.CurrentRow.Cells["fecha_devolucion"].Value.ToString() != "-")
            {
                MessageBox.Show("Este recurso ya fue devuelto anteriormente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvHistorialAlumno.CurrentRow.Cells["id_prestamo"].Value == null)
            {
                MessageBox.Show("No se encontró el identificador del préstamo en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idPrestamo = Convert.ToInt32(dgvHistorialAlumno.CurrentRow.Cells["id_prestamo"].Value);
            string estadoFisico = cboEstadoFisico.SelectedItem != null ? cboEstadoFisico.SelectedItem.ToString() : "Bueno";

            historial nuevaDevolucion = new historial()
            {
                id_prestamo = idPrestamo,
                estado_devolucion = estadoFisico,
                observaciones = txtObservaciones != null ? txtObservaciones.Text.Trim() : ""
            };

            string mensaje;
            bool resultado = objCN_Prestamo.RegistrarDevolucion(nuevaDevolucion, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Devolución registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObservaciones.Clear();
                CargarRecursosDisponibles();
                CargarHistorialAlumno(alumnoSeleccionado.id_persona);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorialAlumno(int idPersona)
        {
            // AQUÍ ESTÁ EL CAMBIO: Ahora llama a ObtenerHistorialPorAlumno filtrando por idPersona
            List<prestamos> lista = objCN_Prestamo.ObtenerHistorialPorAlumno(idPersona);

            dgvHistorialAlumno.DataSource = null;
            dgvHistorialAlumno.Columns.Clear();
            dgvHistorialAlumno.Rows.Clear();

            dgvHistorialAlumno.Columns.Add("id_prestamo", "ID Préstamo");
            dgvHistorialAlumno.Columns["id_prestamo"].Visible = false;

            dgvHistorialAlumno.Columns.Add("id_recurso", "Recurso / Código");
            dgvHistorialAlumno.Columns.Add("fecha_prestamo", "Fecha Préstamo");
            dgvHistorialAlumno.Columns.Add("fecha_devolucion", "Fecha Devolución");
            dgvHistorialAlumno.Columns.Add("estado", "Estado");

            foreach (var item in lista)
            {
                string estadoTexto = string.IsNullOrEmpty(item.fecha_devolucion) ? "Pendiente" : "Devuelto";
                string fechaDev = string.IsNullOrEmpty(item.fecha_devolucion) ? "-" : item.fecha_devolucion;

                dgvHistorialAlumno.Rows.Add(
                    item.id_prestamo,
                    item.id_recurso,
                    item.fecha_prestamo,
                    fechaDev,
                    estadoTexto
                );
            }
        }

        private void LimpiarDatosAlumno()
        {
            alumnoSeleccionado = null;
            lblNombreAlumno.Text = "---";
            dgvHistorialAlumno.Rows.Clear();
        }
    }
}