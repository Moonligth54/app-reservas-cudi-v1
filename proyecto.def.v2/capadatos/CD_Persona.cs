using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using capaentidad;

namespace capadatos
{
    public class CD_Persona
    {
        public List<personas> Listar()
        {
            List<personas> lista = new List<personas>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT id_persona, dni, apellido, nombre, tipo_persona, id_carrera, telefono_emergencia, activo FROM personas";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new personas()
                            {
                                id_persona = Convert.ToInt32(dr["id_persona"]),
                                dni = dr["dni"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                tipo_persona = dr["tipo_persona"].ToString(),
                                id_carrera = dr["id_carrera"] != DBNull.Value ? Convert.ToInt32(dr["id_carrera"]) : (int?)null,
                                telefono_emergencia = dr["telefono_emergencia"] != DBNull.Value ? dr["telefono_emergencia"].ToString() : null,
                                activo = Convert.ToBoolean(dr["activo"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<personas>();
                }
            }
            return lista;
        }

        public personas ObtenerPorDni(string dni)
        {
            personas obj = null;
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT id_persona, dni, apellido, nombre, tipo_persona, id_carrera, telefono_emergencia, activo FROM personas WHERE dni = @dni AND tipo_persona = 'alumno' LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.CommandType = System.Data.CommandType.Text;

                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj = new personas()
                            {
                                id_persona = Convert.ToInt32(dr["id_persona"]),
                                dni = dr["dni"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                tipo_persona = dr["tipo_persona"].ToString(),
                                id_carrera = dr["id_carrera"] != DBNull.Value ? Convert.ToInt32(dr["id_carrera"]) : (int?)null,
                                telefono_emergencia = dr["telefono_emergencia"] != DBNull.Value ? dr["telefono_emergencia"].ToString() : null,
                                activo = Convert.ToBoolean(dr["activo"])
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    obj = null;
                }
            }
            return obj;
        }

        public bool Registrar(personas obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO personas (dni, apellido, nombre, tipo_persona, id_carrera, activo) " +
                                   "VALUES (@dni, @apellido, @nombre, 'Alumno', @id_carrera, 1)";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@dni", obj.dni);
                    cmd.Parameters.AddWithValue("@apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("@id_carrera", (object)obj.id_carrera ?? DBNull.Value);

                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }
    }
}