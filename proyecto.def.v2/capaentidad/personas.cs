using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidad
{
    public class personas
    {
        public int id_persona { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string tipo_persona { get; set; } // "Alumno" o "Pasante"
        public int? id_carrera { get; set; }
        public string telefono_emergencia { get; set; }
        public bool activo { get; set; }
        public string fecha_creacion { get; set; }
    }
}