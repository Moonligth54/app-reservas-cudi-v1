using System;
using MySqlConnector;

namespace WinFormsApp1.DAO
{
    internal class UsuarioDAO
    {
        public bool ExisteUsuario(string usuario, string contraseña)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"SELECT COUNT(*)
                               FROM usuarios
                               WHERE usuario = @usuario
                               AND contrasena = @contraseña
                               AND activo = TRUE";

                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                    return cantidad > 0;
                }
            }
        }
    }
}