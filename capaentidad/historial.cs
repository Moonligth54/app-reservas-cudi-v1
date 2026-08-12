using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidad
{
    public class historial
    {
        public int id_historial { get; set; }
        public int id_prestamo { get; set; }
        public string estado_devolucion { get; set; } // "Bueno", "Regular", "Dañado"
        public string observaciones { get; set; }
        public string fecha_registro { get; set; }
    }
}