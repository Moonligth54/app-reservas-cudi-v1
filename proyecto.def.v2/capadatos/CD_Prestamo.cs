using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using capaentidad;

namespace capadatos
{
    public class CD_Prestamo
    {
        public bool Registrar(prestamos obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    MySqlTransaction tr = oconexion.BeginTransaction();

                    string queryPrestamo = @"INSERT INTO prestamos (id_persona, id_recurso, id_usuario, fecha_prestamo, observaciones) 
                                             VALUES (@id_persona, @id_recurso, @id_usuario, NOW(), @observaciones);";

                    MySqlCommand cmdPrestamo = new MySqlCommand(queryPrestamo, oconexion, tr);
                    cmdPrestamo.Parameters.AddWithValue("@id_persona", obj.id_persona);
                    cmdPrestamo.Parameters.AddWithValue("@id_recurso", obj.id_recurso);
                    cmdPrestamo.Parameters.AddWithValue("@id_usuario", obj.id_usuario);
                    cmdPrestamo.Parameters.AddWithValue("@observaciones", obj.observaciones ?? "");
                    cmdPrestamo.ExecuteNonQuery();

                    string queryRecurso = "UPDATE recursos SET estado = 'Prestado' WHERE id_recurso = @id_recurso;";
                    MySqlCommand cmdRecurso = new MySqlCommand(queryRecurso, oconexion, tr);
                    cmdRecurso.Parameters.AddWithValue("@id_recurso", obj.id_recurso);
                    cmdRecurso.ExecuteNonQuery();

                    tr.Commit();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool RegistrarDevolucion(historial objHistorial, string nuevoEstadoRecurso, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    MySqlTransaction tr = oconexion.BeginTransaction();

                    string queryHistorial = @"INSERT INTO historial (id_prestamo, estado_devolucion, observaciones) 
                                              VALUES (@id_prestamo, @estado_devolucion, @observaciones);";

                    MySqlCommand cmdHistorial = new MySqlCommand(queryHistorial, oconexion, tr);
                    cmdHistorial.Parameters.AddWithValue("@id_prestamo", objHistorial.id_prestamo);
                    cmdHistorial.Parameters.AddWithValue("@estado_devolucion", objHistorial.estado_devolucion);
                    cmdHistorial.Parameters.AddWithValue("@observaciones", objHistorial.observaciones ?? "");
                    cmdHistorial.ExecuteNonQuery();

                    string queryPrestamo = "UPDATE prestamos SET fecha_devolucion = NOW() WHERE id_prestamo = @id_prestamo;";
                    MySqlCommand cmdPrestamo = new MySqlCommand(queryPrestamo, oconexion, tr);
                    cmdPrestamo.Parameters.AddWithValue("@id_prestamo", objHistorial.id_prestamo);
                    cmdPrestamo.ExecuteNonQuery();

                    string queryRecurso = @"UPDATE recursos r 
                                             INNER JOIN prestamos p ON r.id_recurso = p.id_recurso 
                                             SET r.estado = @nuevoEstado 
                                             WHERE p.id_prestamo = @id_prestamo;";
                    MySqlCommand cmdRecurso = new MySqlCommand(queryRecurso, oconexion, tr);
                    cmdRecurso.Parameters.AddWithValue("@nuevoEstado", nuevoEstadoRecurso);
                    cmdRecurso.Parameters.AddWithValue("@id_prestamo", objHistorial.id_prestamo);
                    cmdRecurso.ExecuteNonQuery();

                    tr.Commit();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<recursos> ObtenerComputadorasDisponibles()
        {
            List<recursos> lista = new List<recursos>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT r.id_recurso, CONCAT(c.tipo, ' - Equipo N° ', c.numero_equipo) AS nombre_recurso
                                     FROM recursos r
                                     INNER JOIN computadoras c ON r.id_recurso = c.id_recurso
                                     WHERE r.tipo = 'Computadora' AND r.estado = 'Disponible' AND r.activo = 1;";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new recursos()
                            {
                                id_recurso = Convert.ToInt32(dr["id_recurso"]),
                                observaciones = dr["nombre_recurso"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<recursos>();
                }
            }
            return lista;
        }

        public List<recursos> ObtenerLibrosDisponibles()
        {
            List<recursos> lista = new List<recursos>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT r.id_recurso, CONCAT(tl.titulo, ' (Cód. ', r.id_recurso, ')') AS nombre_recurso
                                     FROM recursos r
                                     INNER JOIN libros l ON r.id_recurso = l.id_recurso
                                     INNER JOIN titulos_libros tl ON l.id_titulo = tl.id_titulo
                                     WHERE r.tipo = 'Libro' AND r.estado = 'Disponible' AND r.activo = 1;";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new recursos()
                            {
                                id_recurso = Convert.ToInt32(dr["id_recurso"]),
                                observaciones = dr["nombre_recurso"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<recursos>();
                }
            }
            return lista;
        }

        // Historial filtrado por Recepcionista/Usuario
        public List<prestamos> ObtenerHistorialPorUsuario(int idUsuario)
        {
            List<prestamos> lista = new List<prestamos>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT id_prestamo, id_persona, id_recurso, id_usuario, 
                                    fecha_prestamo, fecha_devolucion, observaciones 
                             FROM prestamos 
                             WHERE id_usuario = @id_usuario 
                             ORDER BY id_prestamo DESC;";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new prestamos()
                            {
                                id_prestamo = Convert.ToInt32(dr["id_prestamo"]),
                                id_persona = Convert.ToInt32(dr["id_persona"]),
                                id_recurso = Convert.ToInt32(dr["id_recurso"]),
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                fecha_prestamo = Convert.ToDateTime(dr["fecha_prestamo"]).ToString("yyyy-MM-dd HH:mm:ss"),
                                fecha_devolucion = dr["fecha_devolucion"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_devolucion"]).ToString("yyyy-MM-dd HH:mm:ss") : null,
                                observaciones = dr["observaciones"] != DBNull.Value ? dr["observaciones"].ToString() : ""
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<prestamos>();
                }
            }
            return lista;
        }

        // Historial filtrado estrictamente por Alumno
        public List<prestamos> ObtenerHistorialPorAlumno(int idPersona)
        {
            List<prestamos> lista = new List<prestamos>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT id_prestamo, id_persona, id_recurso, id_usuario, 
                                    fecha_prestamo, fecha_devolucion, observaciones 
                             FROM prestamos 
                             WHERE id_persona = @id_persona 
                             ORDER BY id_prestamo DESC;";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@id_persona", idPersona);
                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new prestamos()
                            {
                                id_prestamo = Convert.ToInt32(dr["id_prestamo"]),
                                id_persona = Convert.ToInt32(dr["id_persona"]),
                                id_recurso = Convert.ToInt32(dr["id_recurso"]),
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                fecha_prestamo = Convert.ToDateTime(dr["fecha_prestamo"]).ToString("yyyy-MM-dd HH:mm:ss"),
                                fecha_devolucion = dr["fecha_devolucion"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_devolucion"]).ToString("yyyy-MM-dd HH:mm:ss") : null,
                                observaciones = dr["observaciones"] != DBNull.Value ? dr["observaciones"].ToString() : ""
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<prestamos>();
                }
            }
            return lista;
        }
    }
}