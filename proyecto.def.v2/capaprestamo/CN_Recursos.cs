using System.Data;
using capadatos;

namespace capanegocio
{
    public class CN_Recursos
    {
        private CD_Recursos objcd_recursos = new CD_Recursos();

        public DataTable ObtenerRecursosPorTipo(string tipo)
        {
            return objcd_recursos.ObtenerRecursosPorTipo(tipo);
        }
        public DataTable ObtenerLibros()
        {
            return objcd_recursos.ObtenerLibros();
        }
        public DataTable ObtenerEquiposEnMantenimiento()
        {
            return objcd_recursos.ObtenerEquiposEnMantenimiento();
        }

        public bool CambiarEstado(int idRecurso, string nuevoEstado, out string Mensaje)
        {
            return objcd_recursos.CambiarEstado(idRecurso, nuevoEstado, out Mensaje);
        }
    }
}