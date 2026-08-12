using System;
using System.Windows.Forms;
using capaentidad;
using capanegocio;

namespace capainicio
{
    public partial class frmhistorial : Form
    {
        private usuarios usuarioSesion;

        // Constructor por defecto
        public frmhistorial()
        {
            InitializeComponent();
        }

        // Constructor sobrecargado que recibe el usuario activo
        public frmhistorial(usuarios oUsuario)
        {
            InitializeComponent();
            this.usuarioSesion = oUsuario;
        }

        private void frmhistorial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            if (usuarioSesion != null)
            {
                CN_Prestamo objCN = new CN_Prestamo();
                // Asigna la tabla filtrada al DataGridView (reemplaza dgvHistorial por el nombre de tu DataGridView)
                dgvHistorial.DataSource = objCN.ObtenerHistorialPorUsuario(usuarioSesion.id_usuario);
            }
        }
    }
}