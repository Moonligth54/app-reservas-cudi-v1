using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace capadatos
{
    public class CD_Recursos
    {
        public DataTable ObtenerRecursosPorTipo(string tipo)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se agrega LEFT JOIN con la tabla computadoras para traer el campo c.tipo
                    string query = @"SELECT 
                                        r.id_recurso, 
                                        r.tipo AS tipo_recurso, 
                                        c.tipo AS tipo, 
                                        r.estado, 
                                        r.observaciones 
                                     FROM recursos r 
                                     LEFT JOIN computadoras c ON r.id_recurso = c.id_recurso
                                     WHERE r.tipo = @tipo AND r.activo = 1";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        public DataTable ObtenerLibros()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT 
                                r.id_recurso, 
                                r.tipo AS tipo_recurso, 
                                tl.titulo, 
                                r.estado 
                             FROM recursos r
                             INNER JOIN libros l ON r.id_recurso = l.id_recurso
                             INNER JOIN titulos_libros tl ON l.id_titulo = tl.id_titulo
                             WHERE r.tipo = 'libro' AND r.activo = 1";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        public DataTable ObtenerEquiposEnMantenimiento()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                SELECT 
                    r.id_recurso, 
                    r.tipo AS tipo_recurso, 
                    r.estado AS estado_actual, 
                    COALESCE(
                        (SELECT h.observaciones 
                         FROM historial h 
                         INNER JOIN prestamos p2 ON h.id_prestamo = p2.id_prestamo 
                         WHERE p2.id_recurso = r.id_recurso AND h.observaciones IS NOT NULL AND h.observaciones != '' 
                         ORDER BY h.id_historial DESC LIMIT 1),
                        (SELECT p3.observaciones 
                         FROM prestamos p3 
                         WHERE p3.id_recurso = r.id_recurso AND p3.observaciones IS NOT NULL AND p3.observaciones != '' 
                         ORDER BY p3.id_prestamo DESC LIMIT 1),
                        r.observaciones,
                        'Sin observaciones'
                    ) AS observaciones
                FROM recursos r
                WHERE r.estado = 'Mantenimiento' AND r.activo = 1";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        public bool CambiarEstado(int idRecurso, string nuevoEstado, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE recursos SET estado = @estado WHERE id_recurso = @id_recurso";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@id_recurso", idRecurso);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return respuesta;
        }
    }
}