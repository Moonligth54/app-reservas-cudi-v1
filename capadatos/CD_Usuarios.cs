using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using capaentidad;

namespace capadatos
{
    public class CD_Usuarios
    {
        public List<usuarios> Listar()
        {
            List<usuarios> lista = new List<usuarios>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.usuario, u.contrasena, u.id_rol, u.activo, r.nombre AS nombre_rol 
                                     FROM usuarios u 
                                     INNER JOIN roles r ON u.id_rol = r.id_rol";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new usuarios()
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                usuario = dr["usuario"].ToString(),
                                contrasena = dr["contrasena"].ToString(),
                                id_rol = Convert.ToInt32(dr["id_rol"]),
                                nombre_rol = dr["nombre_rol"].ToString(), // Mapeo del rol
                                activo = Convert.ToBoolean(dr["activo"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<usuarios>();
                }
            }
            return lista;
        }
    }
}