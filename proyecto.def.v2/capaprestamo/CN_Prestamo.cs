using System;
using System.Collections.Generic;
using capadatos;
using capaentidad;

namespace capanegocio
{
    public class CN_Prestamo
    {
        private CD_Prestamo objCD_Prestamo = new CD_Prestamo();

        public bool RegistrarPrestamo(prestamos obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.id_persona <= 0)
            {
                Mensaje = "Debe seleccionar un alumno válido.";
                return false;
            }

            if (obj.id_recurso <= 0)
            {
                Mensaje = "Debe seleccionar un recurso válido.";
                return false;
            }

            // Llama a la Capa de Datos pasando el objeto completo con su id_persona real
            return objCD_Prestamo.Registrar(obj, out Mensaje);
        }

        public bool RegistrarDevolucion(historial obj, out string Mensaje)
        {
            return objCD_Prestamo.RegistrarDevolucion(obj, "Disponible", out Mensaje);
        }

        public List<recursos> ObtenerComputadorasDisponibles()
        {
            return objCD_Prestamo.ObtenerComputadorasDisponibles();
        }

        public List<recursos> ObtenerLibrosDisponibles()
        {
            return objCD_Prestamo.ObtenerLibrosDisponibles();
        }

        public List<prestamos> ObtenerHistorialPorAlumno(int idPersona)
        {
            return objCD_Prestamo.ObtenerHistorialPorAlumno(idPersona);
        }

        public List<prestamos> ObtenerHistorialPorUsuario(int idUsuario)
        {
            return objCD_Prestamo.ObtenerHistorialPorUsuario(idUsuario);
        }
    }
}