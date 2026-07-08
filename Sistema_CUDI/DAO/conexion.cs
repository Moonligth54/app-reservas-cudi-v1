using MySqlConnector;

namespace SistemaCUDI.DAO
{
    public static class Conexion
    {
        private static string cadenaConexion =
            "Server=localhost;" +
            "Database=cudi;" +
            "User=root;" +
            "Password=cudi2026;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}