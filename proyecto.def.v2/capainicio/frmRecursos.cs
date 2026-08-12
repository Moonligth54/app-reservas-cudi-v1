using System;
using System.Data;
using System.Windows.Forms;
using capanegocio;

namespace capainicio
{
    public partial class frmRecursos : Form
    {
        private CN_Recursos objCN_Recursos = new CN_Recursos();

        public frmRecursos()
        {
            InitializeComponent();
        }

        private void frmRecursos_Load(object sender, EventArgs e)
        {
            CargarEquiposEnMantenimiento();
        }

        private void CargarEquiposEnMantenimiento()
        {
            try
            {
                dgvRecursos.Rows.Clear();

                DataTable dt = objCN_Recursos.ObtenerEquiposEnMantenimiento();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int index = dgvRecursos.Rows.Add();
                        DataGridViewRow dgRow = dgvRecursos.Rows[index];

                        // Asignación directa usando las propiedades Name del Designer.cs
                        dgRow.Cells["id_recurso"].Value = row["id_recurso"];
                        dgRow.Cells["codigo"].Value = row["id_recurso"];
                        dgRow.Cells["tipo_recurso"].Value = row["tipo_recurso"];
                        dgRow.Cells["estado"].Value = row["estado_actual"];
                        dgRow.Cells["observaciones"].Value = row["observaciones"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReparado_Click(object sender, EventArgs e)
        {
            if (dgvRecursos.CurrentRow != null && dgvRecursos.CurrentRow.Cells["id_recurso"].Value != null)
            {
                int idRecurso = Convert.ToInt32(dgvRecursos.CurrentRow.Cells["id_recurso"].Value);

                string mensaje;
                if (objCN_Recursos.CambiarEstado(idRecurso, "Disponible", out mensaje))
                {
                    MessageBox.Show("El equipo ha sido reparado correctamente y vuelve a estar Disponible.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarEquiposEnMantenimiento();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila válida de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}