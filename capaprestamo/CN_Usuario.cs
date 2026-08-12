using System.Collections.Generic;
using capadatos;
using capaentidad;

namespace capanegocio
{
    public class CN_Usuario
    {
        private CD_Usuarios objcd_usuario = new CD_Usuarios();

        public List<usuarios> Listar()
        {
            return objcd_usuario.Listar();
        }
    }
}