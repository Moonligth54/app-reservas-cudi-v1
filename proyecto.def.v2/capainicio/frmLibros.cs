using System;
using System.Data;
using System.Windows.Forms;
using capanegocio;

namespace capainicio
{
    public partial class frmLibros : Form
    {
        private CN_Recursos objCN_Recursos = new CN_Recursos();

        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void CargarLibros()
        {
            try
            {
                dgvLibros.Rows.Clear();
                DataTable dt = objCN_Recursos.ObtenerLibros();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvLibros.Rows.Add(new object[] {
                    row["id_recurso"],
                    row["id_recurso"],   // Código / Inventario
                    row["tipo_recurso"], // Categoría ("Libro")
                    row["titulo"],       // <--- Mapeo del Título del libro
                    row["estado"]        // Estado
                });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para registrar un nuevo libro (solo Administrador)
            MessageBox.Show("Registrar nuevo libro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}