using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capaentidad
{
    public class recursos
    {
        public int id_recurso { get; set; }
        public string tipo { get; set; } // "Computadora" o "Libro"
        public string estado { get; set; } // "Disponible", "Prestado", "Mantenimiento", "No disponible"
        public string observaciones { get; set; }
        public bool activo { get; set; }
        public string fecha_creacion { get; set; }
    }
}