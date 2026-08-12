using MySqlConnector;

namespace WinFormsApp1.DAO
{
    public static class Conexion
    {
        private static string cadenaConexion =
            "Server=localhost;" +
            "Database=cudi_base_beta_1.0;" +
            "User=root;" +
            "Password=;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}