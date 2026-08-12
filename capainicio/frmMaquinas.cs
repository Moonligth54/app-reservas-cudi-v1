using System;
using System.Data;
using System.Windows.Forms;
using capanegocio;

namespace capainicio
{
    public partial class frmMaquinas : Form
    {
        private CN_Recursos objCN_Recursos = new CN_Recursos();

        public frmMaquinas()
        {
            InitializeComponent();
        }

        private void frmMaquinas_Load(object sender, EventArgs e)
        {
            CargarFiltros();
            CargarMaquinas();
        }

        private void CargarFiltros()
        {
            cboFiltroEstado.Items.Clear();
            cboFiltroEstado.Items.Add("Todos");
            cboFiltroEstado.Items.Add("Disponible");
            cboFiltroEstado.Items.Add("Prestado");
            cboFiltroEstado.Items.Add("Mantenimiento");
            cboFiltroEstado.SelectedIndex = 0;
        }

        public void RefrescarGrilla()
        {
            CargarMaquinas();
        }

        private void CargarMaquinas()
        {
            try
            {
                dgvMaquinas.Rows.Clear();

                DataTable dt = objCN_Recursos.ObtenerRecursosPorTipo("computadora");

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvMaquinas.Rows.Add(new object[] {
                            row["id_recurso"],
                            row["id_recurso"],                                // Código / Inventario
                            row["tipo_recurso"],                              // Categoría
                            row["tipo"] != DBNull.Value ? row["tipo"] : "",   // Tipo (Notebook, Netbook)
                            row["estado"]                                     // Estado (Disponible/Prestado)
                        });
                    }
                }

                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar máquinas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltros()
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();
            string estadoSeleccionado = cboFiltroEstado.SelectedItem != null ? cboFiltroEstado.SelectedItem.ToString() : "Todos";

            foreach (DataGridViewRow row in dgvMaquinas.Rows)
            {
                if (row.IsNewRow) continue;

                string valorTipo = row.Cells["tipo"].Value != null ? row.Cells["tipo"].Value.ToString().ToLower() : "";
                string valorEstado = row.Cells["estado"].Value != null ? row.Cells["estado"].Value.ToString() : "";

                bool coincideBusqueda = string.IsNullOrEmpty(textoBusqueda) || valorTipo.Contains(textoBusqueda);
                bool coincideEstado = estadoSeleccionado == "Todos" || valorEstado.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase);

                row.Visible = coincideBusqueda && coincideEstado;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cboFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            if (cboFiltroEstado.Items.Count > 0)
            {
                cboFiltroEstado.SelectedIndex = 0;
            }
            AplicarFiltros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar nueva máquina", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}