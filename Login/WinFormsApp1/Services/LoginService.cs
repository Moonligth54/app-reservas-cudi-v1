using System;
using System;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Services
{
    internal class LoginService
    {
        // Valida que el usuario y la contraseña no estén vacíos
        public bool ValidarCampos(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                return false;

            if (string.IsNullOrWhiteSpace(contraseña))
                return false;

            return true;
        }

        // Intenta iniciar sesión utilizando la base de datos
        public bool IniciarSesion(string usuario, string contraseña)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            return usuarioDAO.ExisteUsuario(usuario, contraseña);
        }

        // Prueba si podemos conectarnos a la base de datos
        public bool ProbarConexion()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}