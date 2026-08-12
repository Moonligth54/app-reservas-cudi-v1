using System;
using System.Collections.Generic;
using capadatos;
using capaentidad;

namespace capanegocio
{
    public class CN_Persona
    {
        private CD_Persona objcd_persona = new CD_Persona();

        public List<personas> Listar()
        {
            return objcd_persona.Listar();
        }

        public personas BuscarPorDni(string dni, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(dni))
            {
                mensaje = "Ingrese un número de DNI válido.";
                return null;
            }

            personas alumno = objcd_persona.ObtenerPorDni(dni);

            if (alumno == null)
            {
                mensaje = "No se encontró ningún alumno registrado con ese DNI.";
            }
            else if (!alumno.activo)
            {
                mensaje = "El alumno no está activo para realizar préstamos.";
            }

            return alumno;
        }

        public bool Registrar(personas obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.dni))
                mensaje += "Debe ingresar el DNI.\n";

            if (string.IsNullOrWhiteSpace(obj.nombre))
                mensaje += "Debe ingresar el Nombre.\n";

            if (string.IsNullOrWhiteSpace(obj.apellido))
                mensaje += "Debe ingresar el Apellido.\n";

            if (!string.IsNullOrEmpty(mensaje))
                return false;

            return objcd_persona.Registrar(obj, out mensaje);
        }
    }
}